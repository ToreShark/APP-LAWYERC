using APP_LAWYER.BLL;
using APP_LAWYER.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "1")]
public class SubcategoryController : Controller
{
    private readonly ILogger _logger;
    private readonly UOW _uow;

    public SubcategoryController(UOW uow, ILogger<SubcategoryController> logger)
    {
        _uow = uow;
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        _logger.LogInformation("Create method called");
        return View(await _uow.SubcategoryRepository.ListAllAsync());
    }

    [HttpGet]
    public async Task<IActionResult> Create()
    {
        ViewBag.Categories = await _uow.CategoriRepository.ListAllAsync();
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Subcategory subcategory, string[] videoUrls, string[] videoDescriptions,
        string[] videoTitles, string[] videoYoutubeIds)
    {
        Console.WriteLine("Create method called with subcategory: " + subcategory.Name);
        ViewBag.Categories = await _uow.CategoriRepository.ListAllAsync();
        if (!ModelState.IsValid)
        {
            Console.WriteLine("Model state is invalid");
            var errors = ModelState
                .Where(x => x.Value.Errors.Count > 0)
                .Select(x => new { x.Key, x.Value.Errors })
                .ToArray();

            foreach (var error in errors)
            {
                Console.WriteLine($"Error in property {error.Key}:");
                foreach (var detail in error.Errors) Console.WriteLine(detail.ErrorMessage);
            }

            return View(subcategory);
        }

        await _uow.SubcategoryRepository.InsertAsync(subcategory);

        for (var i = 0; i < videoUrls.Length; i++)
        {
            if (string.IsNullOrEmpty(videoUrls[i]))
            {
                ModelState.AddModelError($"videoUrls[{i}]", "YoutubeId is required.");
                return View(subcategory);
            }

            var videoId = Guid.NewGuid();
            var video = new Video
            {
                Id = videoId,
                Url = videoUrls[i],
                Description = videoDescriptions[i],
                Title = videoTitles[i],
                YoutubeId = videoYoutubeIds[i]
            };
            await _uow.VideoRepository.InsertAsync(video);

            var subcategoryVideo = new SubcategoryVideo
            {
                SubcategoryId = subcategory.Id,
                VideoId = videoId
            };
            await _uow.SubcategoryVideoRepository.InsertAsync(subcategoryVideo);
        }

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Update(Guid id)
    {
        Console.WriteLine("Searching for subcategory with id: " + id);
        var subcategory = await _uow.SubcategoryRepository.GetByGuidSubcategoryAsync(id);
        if (subcategory == null)
        {
            Console.WriteLine("Subcategory not found");
            return NotFound();
        }

        ViewBag.Categories = await _uow.CategoriRepository.ListAllAsync();
        return View(subcategory);
    }

    [HttpPost]
    public async Task<IActionResult> Update(Guid id, string[] videoUrls, string[] videoDescriptions,
        string[] videoTitles, string[] videoYoutubeIds)
    {
        ViewBag.Categories = await _uow.CategoriRepository.ListAllAsync();
        Subcategory subcategory = await _uow.SubcategoryRepository.GetByGuidSubcategoryAsync(id);

        if (subcategory == null)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            Console.WriteLine("CategoryId: " + subcategory.CategoryId);
            await _uow.SubcategoryRepository.UpdateAsync(subcategory);
            var currentVideos = await _uow.VideoRepository.GetVideosForSubcategory(subcategory.Id);

            // Delete videos that are not in the updated list
            foreach (var video in currentVideos)
            {
                if (!videoUrls.Contains(video.Url))
                {
                    await _uow.VideoRepository.DeleteAsync(video);
                }
            }

            // Update existing videos and add new ones
            for (var i = 0; i < videoUrls.Length; i++)
            {
                var existingVideo = currentVideos.FirstOrDefault(v => v.Url == videoUrls[i]);

                if (existingVideo != null)
                {
                    // Update existing video
                    existingVideo.Description = videoDescriptions[i];
                    existingVideo.Title = videoTitles[i];
                    existingVideo.YoutubeId = videoYoutubeIds[i];
                    await _uow.VideoRepository.UpdateAsync(existingVideo);
                }
                else
                {
                    // Add new video
                    var videoId = Guid.NewGuid();
                    var video = new Video
                    {
                        Id = videoId,
                        Url = videoUrls[i],
                        Description = videoDescriptions[i],
                        Title = videoTitles[i],
                        YoutubeId = videoYoutubeIds[i]
                    };
                    await _uow.VideoRepository.InsertAsync(video);

                    var subcategoryVideo = new SubcategoryVideo
                    {
                        SubcategoryId = subcategory.Id,
                        VideoId = videoId
                    };
                    await _uow.SubcategoryVideoRepository.InsertAsync(subcategoryVideo);
                }
            }

            return RedirectToAction(nameof(Index));
        }

        return View(subcategory);
    }


    [HttpGet]
    public async Task<IActionResult> Delete(Guid id)
    {
        var subcategory = await _uow.SubcategoryRepository.GetByGuidSubcategoryAsync(id);
        if (subcategory == null) return NotFound();

        var subcategoryVideos = await _uow.SubcategoryVideoRepository.GetBySubcategoryIdAsync(id);
        var videoIds = subcategoryVideos.Select(sv => sv.VideoId);
        var videos = new List<Video>();
        foreach (var videoId in videoIds)
        {
            var video = await _uow.VideoRepository.GetByIdAsync(videoId);
            if (video != null) videos.Add(video);
        }

        // Добавление видео в ViewBag, чтобы они были доступны в представлении
        ViewBag.Videos = videos;

        return View(subcategory);
    }


    [HttpPost]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var subcategory = await _uow.SubcategoryRepository.GetByGuidSubcategoryAsync(id);
        if (subcategory == null) return NotFound();

        var subcategoryVideos = await _uow.SubcategoryVideoRepository.GetBySubcategoryIdAsync(id);
        foreach (var subcategoryVideo in subcategoryVideos)
        {
            var video = await _uow.VideoRepository.GetByIdAsync(subcategoryVideo.VideoId);
            await _uow.SubcategoryVideoRepository.DeleteAsync(subcategoryVideo); // сначала удалить таблицу
            if (video != null) await _uow.VideoRepository.DeleteAsync(video);
        }

        await _uow.SubcategoryRepository.DeleteAsync(subcategory);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [Route("Admin/Subcategory/DeleteVideo/{videoId}")]
    public async Task<IActionResult> DeleteVideo(Guid videoId)
    {
        var video = await _uow.VideoRepository.GetByIdAsync(videoId);
        if (video == null) return NotFound();

        await _uow.VideoRepository.DeleteAsync(video);
        return Json(new { success = true });
    }
}
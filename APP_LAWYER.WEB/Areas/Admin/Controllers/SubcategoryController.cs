using System.Text.RegularExpressions;
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
    private readonly IWebHostEnvironment _hostingEnvironment;

    public SubcategoryController(UOW uow, ILogger<SubcategoryController> logger, IWebHostEnvironment hostingEnvironment)
    {
        _uow = uow;
        _logger = logger;
        _hostingEnvironment = hostingEnvironment;
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
        string[] videoTitles, string[] videoYoutubeIds, IFormFile ImagePath)
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

        if (ImagePath != null)
        {
            subcategory.ImagePath = await SaveImage(ImagePath);
        }

        subcategory.Image = subcategory.Image ?? "default";
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

    private async Task<string> SaveImage(IFormFile image)
    {
        var path = Path.Combine(_hostingEnvironment.WebRootPath, "images");

        // Проверка на существование директории
        if (!Directory.Exists(path))
        {
            // Создание директории, если она не существует
            Directory.CreateDirectory(path);
        }

        path = Path.Combine(path, image.FileName);

        using (var stream = new FileStream(path, FileMode.Create))
        {
            await image.CopyToAsync(stream);
        }

        return "/images/" + image.FileName;
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
        string[] videoTitles, string[] videoYoutubeIds, Subcategory updatedSubcategory, IFormFile ImagePath)
    {
        Console.WriteLine("Update method called with subcategory: " + updatedSubcategory.Name);
        ViewBag.Categories = await _uow.CategoriRepository.ListAllAsync();
        Subcategory subcategory = await _uow.SubcategoryRepository.GetByGuidSubcategoryAsync(id);

        if (subcategory == null)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            Console.WriteLine("CategoryId: " + subcategory.CategoryId);
            subcategory.Name = updatedSubcategory.Name;
            subcategory.Description = updatedSubcategory.Description;
            subcategory.FullDescription = updatedSubcategory.FullDescription;
            subcategory.Content = RemoveEmptyParagraphs(updatedSubcategory.Content);
            subcategory.MetaTitle = updatedSubcategory.MetaTitle;
            subcategory.MetaKeywords = updatedSubcategory.MetaKeywords;
            subcategory.MetaDescription = updatedSubcategory.MetaDescription;
            subcategory.Slug = updatedSubcategory.Slug;

            // Если предоставлен новый файл изображения, сохраняем его и обновляем ImagePath
            if (ImagePath != null)
            {
                subcategory.ImagePath = await SaveImage(ImagePath);
            }

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
                if (string.IsNullOrEmpty(videoUrls[i]) || string.IsNullOrEmpty(videoDescriptions[i]) ||
                    string.IsNullOrEmpty(videoTitles[i]) || string.IsNullOrEmpty(videoYoutubeIds[i]))
                {
                    // Skip this iteration if any of the values is null or empty
                    continue;
                }

                var existingVideo = currentVideos.FirstOrDefault(v => v.Url == videoUrls[i]);

                if (existingVideo != null)
                {
                    await UpdateExistingVideo(existingVideo, videoDescriptions[i], videoTitles[i], videoYoutubeIds[i]);
                }
                else
                {
                    await AddNewVideo(subcategory.Id, videoUrls[i], videoDescriptions[i], videoTitles[i],
                        videoYoutubeIds[i]);
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(subcategory);
    }


    public static string RemoveEmptyParagraphs(string html)
    {
        return Regex.Replace(html, @"<p>\s*</p>", string.Empty, RegexOptions.Compiled);
    }

    private async Task UpdateExistingVideo(Video existingVideo, string description, string title, string youtubeId)
    {
        existingVideo.Description = description;
        existingVideo.Title = title;
        existingVideo.YoutubeId = youtubeId;
        await _uow.VideoRepository.UpdateAsync(existingVideo);
    }

    private async Task AddNewVideo(Guid subcategoryId, string url, string description, string title, string youtubeId)
    {
        var videoId = Guid.NewGuid();
        var video = new Video
        {
            Id = videoId,
            Url = url,
            Description = description,
            Title = title,
            YoutubeId = youtubeId
        };
        await _uow.VideoRepository.InsertAsync(video);

        var subcategoryVideo = new SubcategoryVideo
        {
            SubcategoryId = subcategoryId,
            VideoId = videoId
        };
        await _uow.SubcategoryVideoRepository.InsertAsync(subcategoryVideo);
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
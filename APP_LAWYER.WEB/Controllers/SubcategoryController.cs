using System.Security.Claims;
using APP_LAWYER.BLL;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.DAL.Enums;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APP_LAWYER.WEB.Controllers;

// [Authorize]
public class SubcategoryController : Controller
{
    private readonly UOW _uow;

    public SubcategoryController(UOW uow)
    {
        _uow = uow;
    }

    [HttpGet]
    public async Task<IActionResult> ViewSubcategory(string slug)
    {
        var subcategory = await _uow.SubcategoryRepository.GetBySlugAsync(slug);

        if (subcategory == null)
        {
            return NotFound();
        }

        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Получить ID текущего пользователя

        if (userId == null)
        {
            // Если пользователь не авторизован, перенаправить его на страницу входа
            return Challenge();
        }

        Guid guidUserId;
        if (!Guid.TryParse(userId, out guidUserId))
        {
            // Обработка ошибки, если userId не может быть преобразован в Guid
            return BadRequest("Invalid user ID");
        }

        var user = await _uow.UserRepository.Get(u => u.Id == guidUserId, include: u => u.Role);

        if (user == null)
        {
            // Если пользователь не найден в базе данных, показать ошибку
            return NotFound();
        }

        if (user.Role.RoleName != subcategory.Role.RoleName)
        {
            // Если пользователь не имеет необходимой роли, показать ему страницу с ошибкой 403
            return Forbid();
        }

        // Если все проверки пройдены, показать подкатегорию
        return View("DetailsForModerators", subcategory);
    }

    public async Task<IActionResult> Index(Guid id)
    {
        var subcategory = await _uow.SubcategoryRepository.GetByGuidAsync(id);
        subcategory.SubcategoryVideos = await _uow.SubcategoryVideoRepository
            .GetAll()
            .Include(sv => sv.Video)
            .Where(sv => sv.SubcategoryId == subcategory.Id)
            .ToListAsync();
        subcategory.SubcategoryVideos = subcategory.SubcategoryVideos.OrderBy(sv => sv.Video.Title).ToList();

        ViewBag.SubcategoryId = subcategory.Id;
        return View(subcategory);
    }

    [HttpGet]
    public async Task<IActionResult> Index(string slug)
    {
        var subcategory = await _uow.SubcategoryRepository.GetBySlugAsyncRepo(slug);
        if (subcategory == null) return NotFound();
    
        if (User.Identity.IsAuthenticated)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Получить ID текущего пользователя

            Guid guidUserId;
            if (!Guid.TryParse(userId, out guidUserId))
            {
                // Обработка ошибки, если userId не может быть преобразован в Guid
                return BadRequest("Invalid user ID");
            }

            var user = await _uow.UserRepository.Get(u => u.Id == guidUserId, include: u => u.Role);

            if (user == null)
            {
                // Если пользователь не найден в базе данных, показать ошибку
                return NotFound();
            }

            if (user.Role.RoleName != RoleName.Moderator && user.Role.RoleName != RoleName.SuperAdmin)
            {
                // Если пользователь не имеет необходимой роли, показать ему страницу с ошибкой 403
                return Forbid();
            }
            
            subcategory.SubcategoryVideos = await _uow.SubcategoryVideoRepository
                .GetAll()
                .Include(sv => sv.Video)
                .Where(sv => sv.SubcategoryId == subcategory.Id)
                .ToListAsync();
            subcategory.SubcategoryVideos = subcategory.SubcategoryVideos.OrderBy(sv => sv.Video.Title).ToList();
        }

        ViewBag.SubcategoryId = subcategory.Id;
        return View(subcategory);
    }
    
    public async Task<IActionResult> Comments(Guid id)
    {
        var comments = await _uow.CommentRepository.GetBySubcategoryIdAsync(id);
        return PartialView("_Comments", comments);
    }

    public async Task<VideoInfo> GetVideoInfo(string videoId)
    {
        var youtubeService = new YouTubeService(new BaseClientService.Initializer
        {
            ApiKey = "AIzaSyC2r-I1RQi2TpyW9Ef7iRFRhI7b8t-c1PU", // Ваш API ключ
            ApplicationName = "prime-legal-385809" // Имя вашего приложения
        });

        var videoRequest = youtubeService.Videos.List("snippet, contentDetails");
        videoRequest.Id = videoId;

        var videoResponse = await videoRequest.ExecuteAsync();

        var videoInfo = new VideoInfo();
        foreach (var video in videoResponse.Items)
        {
            videoInfo.Title = video.Snippet.Title;
            videoInfo.Description = video.Snippet.Description;
            videoInfo.Duration = video.ContentDetails.Duration;
        }

        return videoInfo;
    }

    [HttpPost]
    [Route("/Subcategory/GetNextVideoId")]
    public async Task<string> GetNextVideoId(int index)
    {
        var videos = await _uow.SubcategoryVideoRepository
            .GetAll()
            .Include(sv => sv.Video)
            .OrderBy(sv => sv.Video.Title)
            .ToListAsync();
        if (index < 0 || index >= videos.Count) return null;
        var nextIndex = (index + 1) % videos.Count;
        return videos[nextIndex].Video.YoutubeId;
    }
}
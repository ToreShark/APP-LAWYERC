using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP_LAWYER.BLL;
using APP_LAWYER.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubcategoryController : Controller
    {
        private readonly UOW _uow;
        
        public SubcategoryController(UOW uow)
        {
            _uow = uow;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _uow.SubcategoryRepository.ListAllAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await _uow.CategoriRepository.ListAllAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Subcategory subcategory, string[] videoUrls, string[] videoDescriptions)
        {
            Console.WriteLine("Create method called with subcategory: " + subcategory.Name);
            ViewBag.Categories = await _uow.CategoriRepository.ListAllAsync();
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .Select(x => new { x.Key, x.Value.Errors })
                    .ToArray();

                foreach (var error in errors)
                {
                    Console.WriteLine($"Error in property {error.Key}:");
                    foreach (var detail in error.Errors)
                    {
                        Console.WriteLine(detail.ErrorMessage);
                    }
                }

                return View(subcategory);
            }
            await _uow.SubcategoryRepository.InsertAsync(subcategory);

            for (int i = 0; i < videoUrls.Length; i++)
            {
                Guid videoId = Guid.NewGuid();
                Video video = new Video
                {
                    Id = videoId,
                    Url = videoUrls[i],
                    Description = videoDescriptions[i]
                };
                await _uow.VideoRepository.InsertAsync(video);

                var subcategoryVideo = new SubcategoryVideo
                {
                    SubcategoryId = subcategory.Id,
                    VideoId = videoId,
                };
                await _uow.SubcategoryVideoRepository.InsertAsync(subcategoryVideo);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
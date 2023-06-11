using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP_LAWYER.BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APP_LAWYER.WEB.Controllers
{
    [Authorize]
    public class SubcategoryController : Controller
    {
        private readonly UOW _uow;
    
        public SubcategoryController(UOW uow)
        {
            _uow = uow;
        }
        public async Task<IActionResult> Index(Guid id)
        {
            var subcategory = await _uow.SubcategoryRepository.GetByGuidAsync(id);
            subcategory.SubcategoryVideos = await _uow.SubcategoryVideoRepository
                .GetAll()
                .Include(sv => sv.Video)
                .Where(sv => sv.SubcategoryId == subcategory.Id)
                .ToListAsync();

            ViewBag.SubcategoryId = subcategory.Id;
            return View(subcategory);
        }
        public async Task<IActionResult> Comments(Guid id)
        {
            var comments = await _uow.CommentRepository.GetBySubcategoryIdAsync(id);
            return PartialView("_Comments", comments);
        }
    }
}
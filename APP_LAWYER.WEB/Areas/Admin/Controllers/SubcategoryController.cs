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
        public async Task<IActionResult> Create(Subcategory subcategory)
        {
            if (!ModelState.IsValid)
            {
                return View(subcategory);
            }
            await _uow.SubcategoryRepository.InsertAsync(subcategory);
            // await _uow.SaveAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
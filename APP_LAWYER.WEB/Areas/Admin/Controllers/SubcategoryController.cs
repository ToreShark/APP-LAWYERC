using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP_LAWYER.BLL;
using APP_LAWYER.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        
        public async Task<IActionResult> Delete(Guid id)
        {
            Subcategory subcategory = await _uow.SubcategoryRepository.GetByGuidAsync(id);
            if (subcategory != null)
            {
                await _uow.SubcategoryRepository.DeleteAsync(subcategory);
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _uow.CategoriRepository.ListAllAsync();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Subcategory subcategory, List<string> Videos, List<string> VideoDescription)
        {
            if (ModelState.IsValid)
            {
                for (int i = 0; i < Videos.Count; i++)
                {
                    subcategory.Videos.Add(new Video { Url = Videos[i], Description = VideoDescription[i] });
                }
                await _uow.SubcategoryRepository.InsertAsync(subcategory);
                return RedirectToAction(nameof(Index));
            }
            return View(subcategory);
        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            Subcategory subcategory = await _uow.SubcategoryRepository.GetByGuidAsync(id);
            if (subcategory == null)
            {
                return NotFound();
            }
            return View(subcategory);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Subcategory subcategory)
        {
            if (ModelState.IsValid)
            {
                await _uow.SubcategoryRepository.UpdateAsync(subcategory);
                return RedirectToAction(nameof(Index));
            }
            return View(subcategory);
        }
    }
}
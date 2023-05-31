using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP_LAWYER.BLL;
using APP_LAWYER.WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Controllers
{
    public class CategoryController : Controller
    {
        private readonly UOW _uow;

        public CategoryController(UOW uow)
        {
            _uow = uow;
        }
        public async Task<IActionResult> Details(Guid id)
        {
            var category = await _uow.CategoriRepository.GetByGuidAsync(id);
            var subcategories = await _uow.SubcategoryRepository.GetByCategoryIdAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            var viewModel = new CategoryDetailsViewModel
            {
                Category = category,
                Subcategories = subcategories,
            };

            return View(viewModel);
        }
    }
}
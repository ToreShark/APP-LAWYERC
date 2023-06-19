using APP_LAWYER.BLL;
using APP_LAWYER.WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Controllers;

public class CategoryController : Controller
{
    private readonly UOW _uow;

    public CategoryController(UOW uow)
    {
        _uow = uow;
    }

    // public async Task<IActionResult> Details(Guid id)
    // {
    //     var category = await _uow.CategoriRepository.GetByGuidAsync(id);
    //     var subcategories = await _uow.SubcategoryRepository.GetByCategoryIdAsync(id);
    //
    //     if (category == null) return NotFound();
    //
    //     var viewModel = new CategoryDetailsViewModel
    //     {
    //         Category = category,
    //         Subcategories = subcategories
    //     };
    //
    //     return View(viewModel);
    // }

    public async Task<IActionResult> Details(string slug)
    {
        var category = await _uow.CategoriRepository.GetBySlugAsyncRepo(slug);
        if (category == null) return NotFound();
        var subcategories = await _uow.SubcategoryRepository.GetByCategoryIdAsync(category.Id);
        var viewModel = new CategoryDetailsViewModel
        {
            Category = category,
            Subcategories = subcategories
        };
        return View(viewModel);
    }
    public async Task<IActionResult> NavbarCategories()
    {
        var categories = await _uow.CategoriRepository.ListAllAsync();
        var viewModel = new NavbarCategoriesViewModel
        {
            Categories = categories
        };
        return PartialView("_CategoriesPartial", viewModel);
    }
}
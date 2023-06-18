using APP_LAWYER.BLL;
using APP_LAWYER.WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Views.ViewModels;

public class NavbarCategoriesViewComponent : ViewComponent
{
    private readonly UOW _uow;

    public NavbarCategoriesViewComponent(UOW uow)
    {
        _uow = uow;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var categories = await _uow.CategoriRepository.ListAllAsync();
        var viewModel = new NavbarCategoriesViewModel
        {
            Categories = categories
        };
        return View(viewModel);
    }
}
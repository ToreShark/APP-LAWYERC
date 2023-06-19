using APP_LAWYER.BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "1")]
public class CategoryController : Controller
{
    private readonly UOW _uow;

    public CategoryController(UOW uow)
    {
        _uow = uow;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _uow.CategoriRepository.ListAllAsync());
    }
}
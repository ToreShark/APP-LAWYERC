using System.Diagnostics;
using APP_LAWYER.BLL;
using APP_LAWYER.WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly UOW _uow;

    public HomeController(ILogger<HomeController> logger, UOW uow)
    {
        _logger = logger;
        _uow = uow;
    }


    public async Task<IActionResult> Index()
    {
        var subcategories = await _uow.SubcategoryRepository.ListAllAsync();
        var categories = await _uow.CategoriRepository.ListAllAsync();
        var model = new HomeViewModel
        {
            Categories = categories,
            Subcategories = subcategories
        };
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
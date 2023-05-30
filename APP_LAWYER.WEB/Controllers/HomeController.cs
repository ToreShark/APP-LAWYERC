using System.Diagnostics;
using APP_LAWYER.BLL;
using Microsoft.AspNetCore.Mvc;
using APP_LAWYER.WEB.Models;

namespace APP_LAWYER.WEB.Controllers;

public class HomeController : Controller
{
    private readonly UOW _uow;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, UOW uow)
    {
        _logger = logger;
        _uow = uow;
    }
    

    public async Task<IActionResult> Index()
    {
        var subcategories = await _uow.SubcategoryRepository.ListAllAsync(); 
        return View(subcategories);
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
using APP_LAWYER.DAL.Data;
using APP_LAWYER.WEB.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APP_LAWYER.WEB.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "1")]
public class AdminController : Controller
{
    private readonly AppDbContext _db;

    public AdminController(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IActionResult> Index()
    {
        var categories = await _db.Categories.ToListAsync();
        var subcategories = await _db.Subcategories.ToListAsync();
        var documentTemplates = await _db.DocumentTemplates.ToListAsync();

        var model = new AdminViewModel
        {
            Categories = categories,
            Subcategories = subcategories,
            DocumentTemplates = documentTemplates
        };

        return View(model);
    }
}
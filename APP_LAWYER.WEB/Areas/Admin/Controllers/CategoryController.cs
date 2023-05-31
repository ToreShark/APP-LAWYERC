using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP_LAWYER.BLL;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
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
}
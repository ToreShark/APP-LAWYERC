using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP_LAWYER.BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Controllers
{
    [Authorize]
    public class SubcategoryController : Controller
    {
        private readonly UOW _uow;
    
        public SubcategoryController(UOW uow)
        {
            _uow = uow;
        }
        public async Task<IActionResult> Index(Guid id)
        {
            var subcategory = await _uow.SubcategoryRepository.GetByGuidSubcategoryAsync(id);
            return View(subcategory);
        }
    }
}
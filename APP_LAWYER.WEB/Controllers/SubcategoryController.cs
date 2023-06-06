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
            ViewBag.SubcategoryId = id;
            return View(subcategory);
        }
        public async Task<IActionResult> Comments(Guid id)
        {
            var comments = await _uow.CommentRepository.GetBySubcategoryIdAsync(id);
            return PartialView("_Comments", comments);
        }
    }
    // в отдельном контролллере комментариев будет создание, изменение
    // в этом контроллере будет в методе индекс будет просмотр комментариев через ViewBah передаю ID подкатегории
    // показать foreach и при нажатии заполнении формы отправлять на метод создания комментария
    // после создания комментария показать в Index
    // формочка для создания комментария где будет категория id в другом user Id и они будут скрытыми передавать value="id"
}
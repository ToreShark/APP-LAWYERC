using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP_LAWYER.BLL;
using APP_LAWYER.BLL.Repositories;
using APP_LAWYER.DAL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Areas.Admin.Controllers

{
    [Area("Admin")]
    [Authorize(Roles = "1")]
    public class UsersController : Controller
    {
        private readonly UOW _uow;
        public UsersController(UOW uow)
        {
            _uow = uow;
        }
        
        public async Task<IActionResult> Details()
        {
            var users = await _uow.UserRepository.GetAllUsers();
            return View(users);
        }
    }
}
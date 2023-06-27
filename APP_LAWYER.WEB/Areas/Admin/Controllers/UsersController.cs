using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP_LAWYER.BLL;
using APP_LAWYER.BLL.Repositories;
using APP_LAWYER.DAL.Entities;
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
        private readonly ILogger<UsersController> _logger;
        public UsersController(UOW uow, ILogger<UsersController> logger)
        {
            _uow = uow;
            _logger = logger;
        }
        
        public async Task<IActionResult> Details()
        {
            var users = await _uow.UserRepository.GetAllUsers();
            return View(users);
        }
        
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var user = await _uow.UserRepository.GetUserById(id);
            if(user == null) return NotFound();
            return View(user);
        }
        
        [HttpPost]
        public async Task<IActionResult> Update(User user)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Update: Invalid model state");
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        _logger.LogWarning($"Update: {error.ErrorMessage}");
                    }
                }
                return View(user);
            }
            await _uow.UserRepository.UpdateAsync(user);
            return RedirectToAction(nameof(Details));
        }
    }
}
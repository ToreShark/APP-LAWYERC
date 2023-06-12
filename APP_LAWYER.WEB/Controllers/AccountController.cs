using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using APP_LAWYER.BLL;
using APP_LAWYER.DAL.Entities;
using APP_LAWYER.WEB.Views.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace APP_LAWYER.WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly UOW _uow;
        
        public AccountController(UOW uow)
        {
            _uow = uow;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginviewModel loginViewModel)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    User? user = await _uow.UserRepository.ValidateLoginPasswordAsync(loginViewModel.PhoneNumber, loginViewModel.Password);
                    if (user != null)
                    {
                        await Authenticate(user); // аутентификация
                        return RedirectToAction("Index", "Home");
                    }
                }
                catch (InvalidOperationException ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }
            return View(loginViewModel);
        }
        private async Task Authenticate(User user)
        {
            var roleName = await _uow.RoleRepository.GetRoleNameById(user.RoleId);
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Phone),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, roleName),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };
            ClaimsIdentity id = new ClaimsIdentity(
                claims,
                "ApplicationCookie",
                ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(id),
                new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddDays(1),
                }
            );
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registration(RegisterViewModel registerViewModel)
        {
            if(ModelState.IsValid)
            {
                User? user = await _uow.UserRepository.GetByPhoneNumberAsync(registerViewModel.PhoneNumber);
                if (user == null)
                {
                    User newuser = new User()
                    {
                        Phone = registerViewModel.PhoneNumber,
                        Password = _uow.UserRepository.PasswordHash(registerViewModel.Password),
                        RoleId = await _uow.RoleRepository.GetBasicAsync(),
                        Email = "default@example.com",
                        FirstName = "Default", // Значение по умолчанию
                        LastName = "Default" // Значение по умолчанию
                    };
                    await _uow.UserRepository.InsertAsync(newuser);
                    User registreduser = await _uow.UserRepository.GetByPhoneNumberAsync(registerViewModel.PhoneNumber);
                    await Authenticate(registreduser); // аутентификация
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("PhoneNumber", "Пользователь с таким номером телефона уже существует");
            }
            return View(registerViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
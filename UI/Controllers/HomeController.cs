using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;
using ViewModels.KullaniciVM;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        public readonly IKullaniciService _kullaniciService;

        public HomeController(IKullaniciService kullaniciService)
        {
            _kullaniciService = kullaniciService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(string password, string email)
        {
            var cari = _kullaniciService.CheckLogin(new LoginVM() { Password = password, Email = email });
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var cari = _kullaniciService.CheckLogin(loginVM);

            }
            else
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

    
    }
}

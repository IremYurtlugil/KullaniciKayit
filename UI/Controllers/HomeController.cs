using Business.Services.Abstract;
using DataAcces;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
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
        KKContext context = new KKContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Kullanici k)
        {
           var bilgi = context.Kullanici.FirstOrDefault(a => a.Email == k.Email && a.Password == k.Password);
            if (bilgi != null)
            {
                HttpContext.Session.SetJson("bilgi", bilgi);
                return RedirectToAction("Index", "Kullanici");
            }
            else
            {
                TempData["Error"] = "Error";
                return RedirectToAction("Index", "Home");
            }

            //Kullanici kullanici = HttpContext.Session.GetJson<Kullanici>("kullanici");
            //TempData["KullaniciName"] = kullanici.Name;
            //return View();
        }

        //[HttpGet]
        //public IActionResult Login(Kullanici k)
        //{
        //    var bilgi = context.Kullanici.FirstOrDefault(a => a.Email == k.Email && a.Password == k.Password);
        //    if (bilgi != null)
        //    {
        //        HttpContext.Session.SetJson("kullanici", k);              
        //        return RedirectToAction("Index", "Kullanici");
        //    }
        //    else
        //    {
        //        TempData["Error"] = "Error";
        //        return RedirectToAction("Index", "Home");
        //    }
           
        //}

        //[HttpPost]
        //public IActionResult Login(LoginVM loginVM)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var kullanici = _kullaniciService.CheckLogin(loginVM);
        //        if (kullanici != null)
        //        {
        //            return RedirectToAction("Index", "Kullanici");
        //        }
        //        else
        //        {
        //            return View(nameof(Index));
        //        }
        //    }
            //else
            //{
            //    return View();
            //}
        //}


    }
}

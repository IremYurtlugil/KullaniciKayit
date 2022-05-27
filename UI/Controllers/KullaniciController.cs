using Business.Services.Abstract;
using Business.Services.Concrete;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels.CariVM;

namespace UI.Controllers
{
    public class KullaniciController : Controller
    {
        public readonly ICariService _cariService;
        IAdresService _adresService;
        ITelefonService _telefonService;        

        public KullaniciController(ICariService cariService, IAdresService adresService, ITelefonService telefonService)
        {
            _cariService = cariService;
            _adresService = adresService;
            _telefonService = telefonService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Cari> CariList = _cariService.GetListCari();
            List<CariVM> cariVMs = new List<CariVM>();
            foreach (Cari cari in CariList)
            {

                CariVM cariVM = new CariVM()
                {
                    CariId = cari.CariId,
                    Unvan = cari.Unvan,
                    telefons = cari.Telefonlar.ToList(),
                    Adres = cari.Adresler.ToList()

                };
                cariVMs.Add(cariVM);

            }

            return View(cariVMs);
        }

        [HttpGet]  
        public object loadList(DataSourceLoadOptions loadOptions)
        {
            List<Cari> CariList = _cariService.GetListCari();
            List<CariVM> cariVMs = new List<CariVM>();
            foreach (Cari cari in CariList)
            {

                CariVM cariVM = new CariVM()
                {
                    CariId = cari.CariId,
                    Unvan = cari.Unvan,

                };
                cariVMs.Add(cariVM);

            }
            return DataSourceLoader.Load( cariVMs , loadOptions);
        }
        
        public IActionResult Delete (int id) 
        {
            var cari = _cariService.Delete(id);
            return RedirectToAction("Index", "Kullanici");
        }
        

        [HttpGet]
        public IActionResult LogOut()
        {
         
            return RedirectToAction("Index", "Home");
        }

    }
}

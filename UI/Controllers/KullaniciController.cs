using Business.Services.Abstract;
using Business.Services.Concrete;
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

        public IActionResult Index()
        {
            List<Cari> CariList = new List<Cari>();
            CariList = _cariService.GetListCari();
            List<CariVM> cariVMs = new List<CariVM>();
            foreach (Cari cari in CariList)
            {
                CariVM cariVM = new CariVM()
                { 
                  CariId = cari.CariId,
                  Unvan = cari.Unvan,
                  telefons = cari.Telefonlar,
                  Adres = cari.Adresler                
                                    
                };
                cariVMs.Add(cariVM);
                
            }

            return View(cariVMs);
        }
    }
}

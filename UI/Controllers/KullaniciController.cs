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
            return DataSourceLoader.Load(cariVMs, loadOptions);
        }

        public IActionResult Delete(int id)
        {
            var cari = _cariService.Delete(id);
            return RedirectToAction("Index", "Kullanici");
        }


        [HttpGet]
        public IActionResult LogOut()
        {

            return RedirectToAction("Index", "Home");
        }

        public ActionResult CariEkleComp()
        {

            return ViewComponent("CariEkleGuncelle");
        }

        [HttpPost]
        public ActionResult CariEkleComp(CariVM cariVM, int id)
        {
            var cari = _cariService.AddCari(cariVM, id);
            return View();
        }
        public IActionResult Update() 
        {
            return ViewComponent("CariEkleGuncelle");
        }
        [HttpPost]
        public IActionResult Update(long id, List<string> cariTel, List<string> cariAdres, string unvan)
        {
           var phone = _telefonService.GetList(i => i.CariId == id).Select(i=>i.TelefonId).ToList();
           var address = _adresService.GetList(i => i.CariId == id).Select(i=>i.AdresId).ToList();
           
            if (phone != null)
            {
                foreach (var item in phone)
                {
                    _telefonService.Delete(new Telefon { TelefonId = item });
                }
            }
            if (address != null)
            {
                foreach (var item in address)
                {
                    _adresService.Delete(new Adres { AdresId = item });
                }

            }
            var name = _cariService.Get(i => i.CariId == id);
            name.Unvan = unvan;
            _cariService.Update(name);
            foreach (var item in cariTel)
            {
                _cariService.Add(new Telefon { TelefonNo = item, CariId = id });
            }
            foreach (var item in cariAdres)
            {
                _adresService.Add(new Adres { AdresAcıklama = item, AdresId = id });
            }

            return RedirectToAction("Index", "Kullanici");
        }

        public JsonResult GetTelNo(long id) 
        {
            var phones = _telefonService.GetList(a => a.CariId == id).ToList();
            return Json(phones);
        }

        public JsonResult GetAdres(long id) 
        {
            var address = _adresService.GetList(a => a.CariId == id).ToList();
            return Json(address);
        }

        [HttpPost]

        public IActionResult AddTel(string unvan, List<string> cariTel, List<string> cariAdres, long id) 
        {
            _cariService.Add(new Cari { Unvan=unvan });
            var cari = _cariService.Get(a => a.Unvan == unvan);
            foreach (var item in cariAdres)
            {
                _adresService.Add(new Adres { AdresAcıklama = item, CariId = cari.CariId });
            }
            foreach (var item in cariTel)
            {
                _telefonService.Add(new Telefon { TelefonNo = item, CariId = cari.CariId });
            }
            return RedirectToAction("Index", "Kullanici");
        }
        
       

    }
}
 

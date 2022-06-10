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
                    telefons = cari.Telefonlar.Select(w => w.TelefonNo).ToList(),
                    Adres = cari.Adresler.Select(w => w.AdresAcıklama).ToList()

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
        public ActionResult CariEkleComp(CariVM cariVM)
        {
            var cari = _cariService.AddCari(cariVM);
            return View();
        }

        [HttpGet]
        public IActionResult Update(long CariId)
        {
            Cari cari = _cariService.Get(i => i.CariId == CariId);

            return ViewComponent("CariUpdate", cari);
        }

        [HttpPost]
        public IActionResult Update(CariVM cariVM)
        {
           var phone = _telefonService.GetList(i => i.CariId == cariVM.CariId).Select(i=>i.TelefonId).ToList();
           var address = _adresService.GetList(i => i.CariId == cariVM.CariId).Select(i=>i.AdresId).ToList();
            var vmTelefonList = cariVM.telefons;
            if (phone != null)
            {
                foreach (var item in phone)
                {
                    var tel = _telefonService.GetById(w=>w.TelefonId==item);
                    _telefonService.Delete(tel);
                }

            }
            if (address != null)
            {
                foreach (var item in address)
                {
                    var adr = _adresService.GetById(a =>a.AdresId == item);
                    _adresService.Delete(adr);
                }

            var name = _cariService.Get(i => i.CariId == cariVM.CariId);
            name.Unvan = cariVM.Unvan;
            _cariService.Update(name);

            foreach (var item in cariVM.telefons)
            {
                _telefonService.Add(new Telefon { TelefonNo = item, CariId = cariVM.CariId });
            }
            foreach (var item in cariVM.Adres)
            {
                _adresService.Add(new Adres { AdresAcıklama = item, CariId = cariVM.CariId });
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

        public IActionResult AddTel(string unvan, List<string> cariTel, List<string> cariAdres)
        {
            _cariService.Add(new Cari { Unvan = unvan });
            var cari = _cariService.Get(a => a.Unvan == unvan);
            foreach (var item in cariAdres)
            {
                _adresService.Add(new Adres { AdresAcıklama = item, CariId = cari.CariId });
            }
            foreach (var item in cariTel)
            {
                _telefonService.Add(new Telefon { TelefonNo = item, CariId = cari.CariId });
            }
            return Ok();
        }



    }
}


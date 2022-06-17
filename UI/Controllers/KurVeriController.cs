using Business.Services.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;

namespace UI.Controllers
{
    public class KurVeriController : Controller
    {
        public readonly IKurVeriService _kurVeriService;

        public JsonResult Index(int id)
        {
            var kurVeri = _kurVeriService.GetList(a => a.KurId == id).ToList();
            return Json(kurVeri);

        }
    }
}

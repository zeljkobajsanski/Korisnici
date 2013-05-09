using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Korsinici.Web.ViewModels;
using rs.mvc.Korisnici.Filters;
using rs.mvc.Korisnici.Model;
using Log = Korsinici.Web.Models.Log;

namespace Korsinici.Web.Controllers
{
    [Authorize]
    [LogujAktivnost]
    public class LogoviController : Controller
    {
        public ActionResult Index()
        {
            var model = new LogoviViewModel();
            model.UcitajAplikacije();
            return View(model);
        }

        public ActionResult VratiLogove(string nazivAplikacije, DateTime odDatuma, DateTime doDatuma)
        {
            var model = new LogoviViewModel()
            {
                OdDatuma = odDatuma,
                DoDatuma = doDatuma,
                NazivAplikacije = nazivAplikacije
            };
            var logovi = model.VratiLogove().Select(x => new Log
            {
                Aplikacija = x.Aplikacija,
                Browser = PostaviBrowser(x.Browser),
                KorisnickoIme = x.KorisnickoIme,
                DatumPrijave = x.DatumPrijave,
                IpAdresa = x.IpAdresa,
                VremePoslednjeAktivnosti = x.VremePoslednjeAktivnosti
            });
            return Json(logovi, JsonRequestBehavior.AllowGet);
        }

        private string PostaviBrowser(string browser)
        {
            if (browser.ToLower().Contains("chrome")) return "Chrome";
            if (browser.ToLower().Contains("msie")) return "MSIE";
            if (browser.ToLower().Contains("firefox")) return "Firefox";
            if (browser.ToLower().Contains("opera")) return "Opera";
            if (browser.ToLower().Contains("android")) return "Android";

            return browser;
        }
    }
}

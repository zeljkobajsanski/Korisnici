using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using rs.mvc.Korisnici.Filters;
using rs.mvc.Korisnici.Repository;
using rs.mvc.Korisnici.Services;
using rs.mvc.Korisnici.Utils;

namespace Korsinici.Web.Controllers
{
    [Authorize]
    [LogujAktivnost]
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetHeader()
        {
            using (var r = new AplikacijeRepository())
            {
                var aplikacija = r.VratiAplikaciju("admin");
                ViewBag.Aplikacija = aplikacija;
                var korisnik = Cookies.VratiKorisnikaIzKukija(Request);
                ViewBag.Korisnik = korisnik != null ? korisnik.Korisnik : "";
                return PartialView("_Header");
            }
        }
    }
}

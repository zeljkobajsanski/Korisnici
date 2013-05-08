using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rs.mvc.Korisnici.Repository;

namespace Korsinici.Web.Controllers
{
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
                return PartialView("_Header");
            }
            
        }
    }
}

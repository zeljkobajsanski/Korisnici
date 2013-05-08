using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Korsinici.Web.Models;
using rs.mvc.Korisnici.Model;
using rs.mvc.Korisnici.Repository;

namespace Korsinici.Web.Controllers
{
    [Authorize]
    public class AplikacijeController : Controller
    {
        //
        // GET: /Aplikacije/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VratiAplikacije()
        {
            using (var rf = new RepositoryFactory())
            {
                var aplikacije = rf.AplikacijeRepository.GetAll();
                return Json(aplikacije, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Save(Aplikacija aplikacija)
        {
            if (!ModelState.IsValid)
            {
                return Json("Invalid");
            }
            using (var r = new AplikacijeRepository())
            {
                if (aplikacija.Id == -1)
                {
                    r.Add(aplikacija);
                    r.Save();
                    return Json(Status.Added);
                }
                else
                {
                    var a = r.Get(aplikacija.Id);
                    a.Kod = aplikacija.Kod;
                    a.Naziv = aplikacija.Naziv;
                    a.HomeUrl = aplikacija.HomeUrl;
                    a.Logo = aplikacija.Logo;
                    a.Aktivan = aplikacija.Aktivan;
                    r.Save();
                    return Json(Status.Updated);
                }
            }
           
        }
    }
}

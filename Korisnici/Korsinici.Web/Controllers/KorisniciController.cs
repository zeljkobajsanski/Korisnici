using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Korsinici.Web.Models;
using rs.mvc.Korisnici.Filters;
using rs.mvc.Korisnici.Model;
using rs.mvc.Korisnici.Repository;

namespace Korsinici.Web.Controllers
{
    [Authorize]
    [LogujAktivnost]
    public class KorisniciController : Controller
    {
        //
        // GET: /Korisnici/

        public ActionResult Index()
        {
            using (var r = new AplikacijeRepository())
            {
                var aplikacije = r.GetActive();
                return View(aplikacije);
            }
        }

        public ActionResult VratiKorisnike(int? idAplikacije)
        {
            using (var r = new KorisniciRepository())
            {
                var korisnici = r.VratiKorisnike(idAplikacije == -1 ? null : idAplikacije);
                return Json(korisnici, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Update(Korisnik korisnik)
        {
            using (var r = new KorisniciRepository())
            {
                var k = r.Get(korisnik.Id);
                k.Ime = korisnik.Ime;
                k.Prezime = korisnik.Prezime;
                k.EMail = korisnik.EMail;
                k.Aktivan = korisnik.Aktivan;
                //if (!TryValidateModel(k))
                //{
                //    return Json(Status.ValidationError);
                //}
                if (!Validator.TryValidateObject(k, new ValidationContext(k, null, new Dictionary<object, object>()), new Collection<ValidationResult>()))
                {
                    return Json(Status.ValidationError);
                }
                r.Save();
                return Json(Status.Updated);
            }
        }
    }
}

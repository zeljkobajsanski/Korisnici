using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Korsinici.Web.Models;
using rs.mvc.Korisnici.Model;
using rs.mvc.Korisnici.Services;

namespace Korsinici.Web.Controllers
{
    public class AccountController : Controller
    {

        public ActionResult Login(string appCode)
        {
            ViewBag.Application = appCode;
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            try
            {
                Korisnici.PrijaviKorisnika(user.Username, user.Password, user.Application);
                return Json("ok");
            }
            catch (Exception exc)
            {
                throw new HttpException((int)HttpStatusCode.NotFound, "Greska prilikom prijave", exc);
            }
        }

    }
}

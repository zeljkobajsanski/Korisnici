using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Korsinici.Web.Models;
using Korsinici.Web.ViewModels;
using rs.mvc.Korisnici.Filters;
using rs.mvc.Korisnici.Model;
using rs.mvc.Korisnici.Repository;
using rs.mvc.Korisnici.Services;

namespace Korsinici.Web.Controllers
{
    public class AccountController : Controller
    {

        public ActionResult Login(string appCode)
        {
            using (var r = new AplikacijeRepository())
            {
                var app = r.VratiAplikaciju(appCode);
                if (app == null) return HttpNotFound("Aplikacija nije pronađena");
                var viewModel = new LoginViewModel {
                    ApplicationCode = appCode, 
                    ApplicationName = app.Naziv, 
                    Logo = app.Logo,
                    User = new User() {Application = appCode}};
                return View(viewModel);    
            }
            
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                var korisnik = Korisnici.PrijaviKorisnika(model.User.Username, model.User.Password, model.User.Application);
                var log = new Log
                {
                    KorisnickoIme = korisnik.KorisnickoIme,
                    DatumPrijave = DateTime.Now,
                    VremePoslednjeAktivnosti = DateTime.Now
                };

                Aplikacija aplikacija;
                using (var rf = new RepositoryFactory())
                {
                    aplikacija = rf.AplikacijeRepository.VratiAplikaciju(model.User.Application);
                    log.Aplikacija = aplikacija.Naziv;
                    rf.LogoviKorisnikaRepository.Add(log);
                    rf.LogoviKorisnikaRepository.Save();
                }

                var cookie = FormsAuthentication.GetAuthCookie(korisnik.KorisnickoIme, false);
                var ticket = new FormsAuthenticationTicket(1, korisnik.KorisnickoIme, DateTime.Now, DateTime.Now.AddMonths(6), false, log.Id.ToString());
                cookie.Value = FormsAuthentication.Encrypt(ticket);
                Response.Cookies.Add(cookie);
                var url = aplikacija.HomeUrl;
                return RedirectPermanent(url);
            }
            catch (Exception exc)
            {
                TempData["Error"] = exc.Message;
                return View("Login", model);
            }
        }

        public ActionResult Register(string appCode)
        {
            using (var rf = new RepositoryFactory())
            {
                var app = rf.AplikacijeRepository.VratiAplikaciju(appCode);
                if (app == null) return HttpNotFound("Aplikacija nije pronađena");
                return View(new RegisterViewModel()
                {
                    ApplicationCode = appCode,
                    ApplicationName = app.Naziv,
                    Logo = app.Logo
                });
            }
            
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            try
            {
                Korisnici.KreirajKorisnika(model.Korisnik, model.ApplicationCode);
            }
            catch (DbUpdateException dbe)
            {
                var inner = dbe.InnerException.InnerException as SqlException;
                if (inner != null)
                {
                    switch (inner.Number)
                    {
                        case 2627:
                            TempData["Error"] = "Korisničko ime je zauzeto";
                            break;
                    }    
                }
                
                return View(model);
            }
            return RedirectToAction("Login", new {appCode = model.ApplicationCode});
        }
    }
}

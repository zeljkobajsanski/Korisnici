using System;
using System.Collections.Generic;
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
                var viewModel = new LoginViewModel {
                    ApplicationCode = appCode, 
                    ApplicationName = app.Naziv, 
                    Logo = app.Logo,
                    User = new User() {Application = appCode}};
                return View(viewModel);    
            }
            
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", new LoginViewModel {ApplicationCode = user.Application, User = user});
            }
            try
            {
                var korisnik = Korisnici.PrijaviKorisnika(user.Username, user.Password, user.Application);
                var log = new Log
                {
                    KorisnickoIme = korisnik.KorisnickoIme,
                    DatumPrijave = DateTime.Now,
                    VremePoslednjeAktivnosti = DateTime.Now
                };
                using (var logoviRepository = new LogoviKorisnikaRepository())
                {
                    logoviRepository.Add(log);
                    logoviRepository.Save();
                }
                var cookie = FormsAuthentication.GetAuthCookie(korisnik.KorisnickoIme, false);
                var ticket = new FormsAuthenticationTicket(1, korisnik.KorisnickoIme, DateTime.Now, DateTime.Now.AddMonths(6), false, log.Id.ToString());
                cookie.Value = FormsAuthentication.Encrypt(ticket);
                Response.Cookies.Add(cookie);
                var url = korisnik.Aplikacija.HomeUrl;
                return RedirectPermanent(url);
            }
            catch (Exception exc)
            {
                TempData["Error"] = exc.Message;
                return View("Login", new LoginViewModel { ApplicationCode = user.Application, User = user });
            }
        }
    }
}

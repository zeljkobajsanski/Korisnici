using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
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
                Aplikacija aplikacija;
                using (var appRepos = new AplikacijeRepository())
                {
                    aplikacija = appRepos.VratiAplikaciju(user.Application);
                }
                using (var logoviRepository = new LogoviKorisnikaRepository())
                {
                    log.Aplikacija = aplikacija.Naziv;
                    log.IpAdresa = HttpContext.Request.UserHostAddress;
                    log.Browser = HttpContext.Request.UserAgent;
                    logoviRepository.Add(log);
                    logoviRepository.Save();
                }
                var cookie = FormsAuthentication.GetAuthCookie(korisnik.KorisnickoIme, false);
                var ticket = new FormsAuthenticationTicket(1, korisnik.KorisnickoIme, DateTime.Now, DateTime.Now.AddMonths(6), false, "");
                cookie.Value = FormsAuthentication.Encrypt(ticket);
                Response.Cookies.Add(cookie);
                var ser = new JavaScriptSerializer();
                var idLogaCookie = new HttpCookie("korisnici_idLoga", log.Id.ToString());
                Response.Cookies.Add(idLogaCookie);
                var korisnikCookie = new HttpCookie("korisnici_korisnik", ser.Serialize(new
                {
                    KorisnickoIme = korisnik.KorisnickoIme,
                    Korisnik = korisnik.Ime + " " + korisnik.Prezime,
                    Admin = korisnik.Administrator
                }));
                Response.Cookies.Add(korisnikCookie);
                var url = korisnik.Aplikacije.Single(x => x.Kod == user.Application).HomeUrl;
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

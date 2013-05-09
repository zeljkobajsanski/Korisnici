using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
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
using rs.mvc.Korisnici.Utils;
using Log = rs.mvc.Korisnici.Model.Log;

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
                    log.IpAdresa = HttpContext.Request.UserHostAddress;
                    log.Browser = HttpContext.Request.UserAgent;
                    rf.LogoviKorisnikaRepository.Add(log);
                    rf.LogoviKorisnikaRepository.Save();
                }

                var cookie = FormsAuthentication.GetAuthCookie(korisnik.KorisnickoIme, false);
                var ticket = new FormsAuthenticationTicket(1, korisnik.KorisnickoIme, DateTime.Now, DateTime.Now.AddMonths(6), false, korisnik.Id.ToString());
                cookie.Value = FormsAuthentication.Encrypt(ticket);
                Response.Cookies.Add(cookie);
                var ser = new JavaScriptSerializer();
                var idLogaCookie = new HttpCookie("korisnici_idLoga", log.Id.ToString());
                Response.Cookies.Add(idLogaCookie);
                var korisnikCookie = new HttpCookie("korisnici_korisnik", ser.Serialize(new KorisnikCookie()
                {
                    KorisnickoIme =  korisnik.KorisnickoIme,
                    Korisnik = korisnik.Ime + " " + korisnik.Prezime,
                    Administrator = korisnik.Administrator
                }));
                Response.Cookies.Add(korisnikCookie);
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
                HandleDbException(dbe);
                return View(model);
            }
            return RedirectToAction("Login", new {appCode = model.ApplicationCode});
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", new{appcode = "admin"});
        }

        public ActionResult MojProfil(string verificationKey)
        {
            if (!string.IsNullOrEmpty(verificationKey))
            {
                using (var r = new KorisniciRepository())
                {
                    var korisnik = r.VratiKorisnikaPoTmpPasswordu(verificationKey);
                    if (korisnik == null) return HttpNotFound("Korisnik nije pronađen");
                    return View(korisnik);
                }
            }
            var authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            if (authCookie != null)
            {
                var formsAuthenticationTicket = FormsAuthentication.Decrypt(authCookie.Value);
                if (formsAuthenticationTicket != null)
                {
                    var value = formsAuthenticationTicket.UserData;
                    int id;
                    if (Int32.TryParse(value, out id))
                    {
                        using (var r = new KorisniciRepository())
                        {
                            var korisnik = r.Get(id);
                            return View(korisnik);
                        }
                    }
                }
            }
            return HttpNotFound("Korisnik nije pronađen");
        }

        [HttpPost]
        public ActionResult MojProfil(Korisnik korisnik)
        {
            ModelState.Clear();
            using (var r = new KorisniciRepository())
            {
                var k = r.Get(korisnik.Id);
                k.Ime = korisnik.Ime;
                k.Prezime = korisnik.Prezime;
                k.EMail = korisnik.EMail;

                var validationResults = new List<ValidationResult>();
                if (!Validator.TryValidateObject(k, new ValidationContext(k, null, new Dictionary<object, object>()), validationResults))
                {
                    foreach (var validationResult in validationResults)
                    {
                        foreach (var member in validationResult.MemberNames)
                        {
                            ModelState.AddModelError(member, validationResult.ErrorMessage);
                        }
                    }
                    return View(korisnik);
                }
                try
                {
                    r.Save();
                }
                catch(DbUpdateException dbe)
                {
                    HandleDbException(dbe);
                    korisnik.KorisnickoIme = k.KorisnickoIme;
                    return View(korisnik);
                }
            }
            TempData["Status"] = "OK";
            return RedirectToAction("MojProfil");
        }

        [HttpPost]
        public ActionResult PromeniLozinku(int id, string novaLozinka)
        {
            using (var r = new KorisniciRepository())
            {
                var korisnik = r.Get(id);
                if (korisnik == null) throw new HttpException("Korisnik nije pronađen");
                korisnik.Lozinka = HashUtils.GetHash(novaLozinka);
                korisnik.TemporaryPassword = null;
                r.Save();
            }
            return new EmptyResult();
        }

        public ActionResult ZaboravljenaLozinka()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ZaboravljenaLozinka(string email)
        {
            using (var r = new KorisniciRepository())
            {
                var korisnik = r.VratiKorisnika(email);
                if (korisnik == null) return Json(new {Status = Status.Error, Message = "Korisnik nije pronađen"});
                korisnik.TemporaryPassword = Guid.NewGuid().ToString("N");
                r.Save();
                using (var smtp = new SmtpClient())
                {
                     using (var sw = new StringWriter())
                    {
                        ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, "RecoveryPasswordEmail");
                        ViewData["Korisnik"] = korisnik;
                        var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                        viewResult.View.Render(viewContext, sw);
                        var emailBody = sw.GetStringBuilder().ToString();
                        var mailMessage = new MailMessage("zeljko.bajanski@gmail.com", korisnik.EMail)
                        {
                            IsBodyHtml = true,
                            Body = emailBody,
                            Subject = "Zahtev za promenu lozinke"
                        };
                        smtp.Send(mailMessage);
                    }
                }
            }
            return Json(new {Status = Status.Success, Message = "E-mail sa linkom za reset lozinke je poslat na vašu adresu"});
        }

        private void HandleDbException(DbUpdateException dbe)
        {
            var inner = dbe.InnerException.InnerException as SqlException;
            if (inner != null)
            {
                switch (inner.Number)
                {
                    case 2627:
                        TempData["Error"] = "Korisničko ime ili E-mail je zauzet";
                        break;
                }
            }
        }
    }
}

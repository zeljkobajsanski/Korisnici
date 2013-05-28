using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Web;
using Korsinici.Web.Models;
using rs.mvc.Korisnici.Model;
using rs.mvc.Korisnici.Repository;
using rs.mvc.Korisnici.Services;
using rs.mvc.Korisnici.Utils;

namespace Korsinici.Web
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AccountsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AccountsService.svc or AccountsService.svc.cs at the Solution Explorer and start debugging.
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class AccountsService
    {
        [OperationContract]
        public Login Login(string username, string password, string appCode, string machine)
        {
            try
            {
                var korisnik = Korisnici.ProveriKorisnika(username, password, appCode);
                var log = Korisnici.PrijaviKorisnika(username, appCode, HttpContext.Current.Request.UserHostAddress, "windows");
                return new Login
                {
                    IdKorisnika = korisnik.Id,
                    KorisnickoIme = korisnik.KorisnickoIme,
                    ImeIPrezime = korisnik.Ime + " " + korisnik.Prezime,
                    Status = "Ok",
                    LogId = log.Id
                };
            }
            catch (Exception exc)
            {
                return new Login(){Status = "Error", StatusMessage = exc.Message};
            }
        }

        [OperationContract]
        public void Logout(int logId)
        {
            Korisnici.OdjaviKorisnika(logId);
        }

        [OperationContract]
        public Korisnik GetUserInfo(int id)
        {
            return new KorisniciRepository().Get(id);
        }

        [OperationContract]
        public void Save(Korisnik korisnik)
        {
            var repos = new KorisniciRepository();
            repos.Update(korisnik);
            repos.Save();
        }

        [OperationContract]
        public void ChangePassword(int userid, string newPassword)
        {
            using (var r = new KorisniciRepository())
            {
                var korisnik = r.Get(userid);
                if (korisnik == null) throw new HttpException("Korisnik nije pronađen");
                korisnik.Lozinka = HashUtils.GetHash(newPassword);
                korisnik.TemporaryPassword = null;
                r.Save();
            }
        }

        [OperationContract]
        public bool ResetPassword(string username, string appCode)
        {
            try
            {
                var rf = new RepositoryFactory();
                var korisnik = rf.KorisniciRepository.VratiKorisnika(username, appCode);
                var aplikacija = rf.AplikacijeRepository.VratiAplikaciju(appCode);
                if (korisnik == null || aplikacija == null) return false;
                var password = Guid.NewGuid().ToString("N");
                korisnik.TemporaryPassword = password;
                rf.KorisniciRepository.Save();
                var sb = new StringBuilder();
                sb.Append("<div style=\"font-family: 'segoe ui', arial, sans-serif;\">");
                sb.Append("<p>Poštovani ").Append(korisnik.Ime + " " + korisnik.Prezime).Append("<br/>");
                sb.Append("Primili ste ovaj e-mail pošto ste zahtevali promenu lozinke za aplikaciju ").Append(aplikacija.Naziv).Append("</p>");
                sb.Append("<p>Vaša nova lozinka je: " + password).Append("</p>");
                sb.Append("<p>Srdačan pozdrav, <br/>").Append(aplikacija.Naziv).Append(" tim</p>");
                var host = new Uri(HttpContext.Current.Request.Url.AbsoluteUri).GetLeftPart(UriPartial.Authority);
                sb.Append("<img src='").Append(host + "/Content/images/logo/" + aplikacija.Logo).Append("' alt='' />");
                using (var smtp = new SmtpClient())
                {
                    var emailBody = sb.ToString();
                    var mailMessage = new MailMessage("zeljko.bajsanski@gmail.com", korisnik.EMail)
                    {
                        IsBodyHtml = true,
                        Body = emailBody,
                        Subject = "Zahtev za promenu lozinke",
                        BodyEncoding = Encoding.UTF8
                    };
                    smtp.Send(mailMessage);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

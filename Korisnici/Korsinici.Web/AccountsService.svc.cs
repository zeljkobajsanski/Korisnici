using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
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
    public class AccountsService
    {
        [OperationContract]
        public Login Login(string username, string password, string appCode)
        {
            try
            {
                var korisnik = Korisnici.ProveriKorisnika(username, password, appCode);
                var log = Korisnici.PrijaviKorisnika(username, appCode, null, "windows");
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
    }
}

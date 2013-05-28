using System;
using System.Security.Cryptography;
using System.Text;
using rs.mvc.Korisnici.Model;
using rs.mvc.Korisnici.Repository;
using System.Linq;
using rs.mvc.Korisnici.Utils;

namespace rs.mvc.Korisnici.Services
{
    public static class Korisnici
    {
         public static void KreirajKorisnika(Korisnik korisnik, string kodAplikacije)
         {
             using (var r = new RepositoryFactory())
             {
                 var hash = HashUtils.GetHash(korisnik.LozinkaPlain);
                 korisnik.Lozinka = hash;
                 r.KorisniciRepository.Add(korisnik);
                 if (!string.IsNullOrEmpty(kodAplikacije))
                 {
                     var app = r.AplikacijeRepository.VratiAplikaciju(kodAplikacije);
                     if (app != null)
                     {
                         korisnik.Aplikacije.Add(app);
                     }
                 }
                 r.KorisniciRepository.Save();
             }
         }

        public static Korisnik ProveriKorisnika(string korisnickoIme, string lozinka, string aplikacija)
        {
            using (var r = new RepositoryFactory())
            {
                var korisnik = r.KorisniciRepository.VratiKorisnika(korisnickoIme, aplikacija);
                if (korisnik == null) throw new Exception("Korisnik ne postoji");
                if (!korisnik.Aktivan) throw new Exception("Korisnički nalog nije aktiviran");
                var pwd = HashUtils.GetHash(lozinka);
                if (!pwd.SequenceEqual(korisnik.Lozinka)) throw new Exception("Lozinka se ne poklapa");
                return korisnik;
            }
        }

        public static Log PrijaviKorisnika(string korisnickoIme, string appCode, string ipAdresa, string browser)
        {
            using (var r = new RepositoryFactory())
            {
                var app = r.AplikacijeRepository.VratiAplikaciju(appCode);
                var log = r.LogoviKorisnikaRepository.Add(new Log()
                {
                    KorisnickoIme = korisnickoIme,
                    DatumPrijave = DateTime.Now,
                    VremePoslednjeAktivnosti = DateTime.Now,
                    Aplikacija = app.Naziv,
                    IpAdresa = ipAdresa,
                    Browser = browser,
                    Aktivan = true,
                });
                r.LogoviKorisnikaRepository.Save();
                return log;
            }
        }

        public static void OdjaviKorisnika(int logId)
        {
            using (var r = new LogoviKorisnikaRepository())
            {
                var log = r.Get(logId);
                log.Aktivan = false;
                log.VremeOdjave = DateTime.Now;
                r.Save();
            }
        }
    }
}
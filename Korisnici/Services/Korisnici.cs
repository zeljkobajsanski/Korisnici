using System;
using System.Security.Cryptography;
using System.Text;
using rs.mvc.Korisnici.Model;
using rs.mvc.Korisnici.Repository;
using System.Linq;

namespace rs.mvc.Korisnici.Services
{
    public static class Korisnici
    {
         public static void KreirajKorisnika(Korisnik korisnik, string kodAplikacije)
         {
             using (var r = new Repository<Korisnik>())
             {
                 var hash = Hash(korisnik.LozinkaPlain);
                 korisnik.Lozinka = hash;
                 r.Add(korisnik);
                 if (!string.IsNullOrEmpty(kodAplikacije))
                 {
                     using (var ar = new AplikacijeRepository())
                     {
                         korisnik.AplikacijaId = ar.VratiIdAplikacije(kodAplikacije);
                     }
                 }
                 r.Save();
             }
         }

        private static byte[] Hash(string lozinkaPlain)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.Unicode.GetBytes(lozinkaPlain);
            byte[] hash = md5.ComputeHash(inputBytes);
            return hash;
        }

        public static Korisnik PrijaviKorisnika(string korisnickoIme, string lozinka, string aplikacija)
        {
            using (var r = new KorisniciRepository())
            {
                var korisnik = r.VratiKorisnika(korisnickoIme, aplikacija);
                if (korisnik == null) throw new Exception("Korisnik ne postoji");
                var pwd = Hash(lozinka);
                if (!pwd.SequenceEqual(korisnik.Lozinka)) throw new Exception("Lozinka se ne poklapa");
                return korisnik;
            }
        }
    }
}
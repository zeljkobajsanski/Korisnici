using System.Security.Cryptography;
using System.Text;
using rs.mvc.Korisnici.Model;
using rs.mvc.Korisnici.Repository;

namespace rs.mvc.Korisnici.Services
{
    public static class Korisnici
    {
         public static void KreirajKorisnika(Korisnik korisnik, string kodAplikacije)
         {
             using (var r = new Repository<Korisnik>())
             {
                 MD5 md5 = MD5.Create();
                 byte[] inputBytes = Encoding.Unicode.GetBytes(korisnik.LozinkaPlain);
                 byte[] hash = md5.ComputeHash(inputBytes);
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
    }
}
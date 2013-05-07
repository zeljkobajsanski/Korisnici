using System.Collections.Generic;
using System.Linq;
using rs.mvc.Korisnici.Model;

namespace rs.mvc.Korisnici.Repository
{
    public class KorisniciRepository : Repository<Korisnik>
    {
        public Korisnik VratiKorisnika(string korisnickoIme, string aplikacija)
        {
            return
                DataContext.Korisnici.Include("Aplikacija").SingleOrDefault(
                    x => x.Aplikacija.Kod == aplikacija && x.KorisnickoIme == korisnickoIme);
        }
    }
}
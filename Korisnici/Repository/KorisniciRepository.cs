using System.Collections.Generic;
using System.Linq;
using rs.mvc.Korisnici.Model;

namespace rs.mvc.Korisnici.Repository
{
    public class KorisniciRepository : Repository<Korisnik>
    {
        public KorisniciRepository()
        {
        }

        public KorisniciRepository(DataContext dataContext) : base(dataContext)
        {
            
        }

        public Korisnik VratiKorisnika(string korisnickoIme, string aplikacija)
        {
            return
                DataContext.Korisnici.Include("Aplikacije")
                           .SingleOrDefault(
                               x => x.KorisnickoIme == korisnickoIme && x.Aplikacije.Any(app => app.Kod == aplikacija));
        }
    }
}
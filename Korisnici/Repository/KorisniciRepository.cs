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

        public IEnumerable<Korisnik> VratiKorisnike(int? idAplikacije)
        {
            var korisnici = DataContext.Korisnici.AsQueryable();
            if (idAplikacije.HasValue)
            {
                korisnici = korisnici.Where(x => x.Aplikacije.Any(app => app.Id == idAplikacije.Value));
            }
            return korisnici.ToArray();
        }

        public Korisnik VratiKorisnika(string email)
        {
            return DataContext.Korisnici.SingleOrDefault(x => x.EMail == email);
        }

        public Korisnik VratiKorisnikaPoTmpPasswordu(string temporaryPassword)
        {
            return DataContext.Korisnici.SingleOrDefault(x => x.TemporaryPassword == temporaryPassword);
        }
    }
}
using System.Collections.Generic;
using rs.mvc.Korisnici.Model;
using System.Linq;

namespace rs.mvc.Korisnici.Repository
{
    public class AplikacijeRepository : Repository<Aplikacija>
    {
         public int? VratiIdAplikacije(string kod)
         {
             var aplikacija = DataContext.Aplikacije.SingleOrDefault(x => x.Kod == kod);
             return aplikacija != null ? aplikacija.Id : (int?)null;
         }

         public IEnumerable<Korisnik> VratiKorisnikeAplikacije(string kodAplikacije)
         {
             var aplikacija = DataContext.Aplikacije.Include("Korisnici").SingleOrDefault(x => x.Kod == kodAplikacije);
             return aplikacija != null ? aplikacija.Korisnici.ToArray() : Enumerable.Empty<Korisnik>();
         }

        public Aplikacija VratiAplikaciju(string appCode)
        {
            return DataContext.Aplikacije.SingleOrDefault(x => x.Kod == appCode);
        }
    }
}
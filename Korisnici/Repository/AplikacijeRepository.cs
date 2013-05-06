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
             return DataContext.Korisnici.Include("Aplikacija").Where(x => x.Aplikacija.Kod == kodAplikacije).ToArray();
         } 
    }
}
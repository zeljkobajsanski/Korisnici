using rs.mvc.Korisnici.Model;

namespace rs.mvc.Korisnici.Repository
{
    public class LogoviKorisnikaRepository : Repository<Log>
    {
        public LogoviKorisnikaRepository()
        {
        }

        public LogoviKorisnikaRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
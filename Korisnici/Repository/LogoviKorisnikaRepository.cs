using System;
using System.Collections.Generic;
using rs.mvc.Korisnici.Model;
using System.Linq;

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

        public IEnumerable<Log> VratiLogove(string nazivAplikacije, DateTime odDatuma, DateTime doDatuma)
        {
            var logovi = DataContext.LogoviKorisnika.AsEnumerable()
                                    .Where(x => odDatuma.Date <= x.DatumPrijave.Date && x.DatumPrijave.Date <= doDatuma.Date);
            if (!string.IsNullOrEmpty(nazivAplikacije))
            {
                logovi = logovi.Where(x => x.Aplikacija == nazivAplikacije);
            }
            return logovi.ToArray();

        }
    }
}
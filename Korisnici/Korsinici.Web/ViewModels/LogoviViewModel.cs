using System;
using System.Collections.Generic;
using System.Linq;
using rs.mvc.Korisnici.Model;
using rs.mvc.Korisnici.Repository;

namespace Korsinici.Web.ViewModels
{
    public class LogoviViewModel
    {
        private readonly RepositoryFactory m_RepositoryFactory = new RepositoryFactory();

        public LogoviViewModel()
        {
            OdDatuma = DateTime.Now.Date.Subtract(TimeSpan.FromDays(1));
            DoDatuma = DateTime.Now.Date;
            Aplikacije = Enumerable.Empty<Aplikacija>();
        }

        public string NazivAplikacije { get; set; }
        public DateTime OdDatuma { get; set; }
        public DateTime DoDatuma { get; set; }
        public IEnumerable<Aplikacija> Aplikacije { get; set; } 

        public void UcitajAplikacije()
        {
            Aplikacije = m_RepositoryFactory.AplikacijeRepository.GetActive();
        }

        public IEnumerable<Log> VratiLogove()
        {
            return m_RepositoryFactory.LogoviKorisnikaRepository.VratiLogove(NazivAplikacije, OdDatuma, DoDatuma).OrderByDescending(x => x.VremePoslednjeAktivnosti);
        }
    }
}
using System;
using rs.mvc.Korisnici.Model;

namespace rs.mvc.Korisnici.Repository
{
    public class RepositoryFactory : IDisposable
    {
        private readonly DataContext m_DataContext = new DataContext();

        public AplikacijeRepository AplikacijeRepository {get {return new AplikacijeRepository(m_DataContext);}}

        public KorisniciRepository KorisniciRepository {get {return new KorisniciRepository(m_DataContext);}}

        public LogoviKorisnikaRepository LogoviKorisnikaRepository {get {return new LogoviKorisnikaRepository(m_DataContext);}}
        
        public void Dispose()
        {
            m_DataContext.Dispose();
        }
    }
}
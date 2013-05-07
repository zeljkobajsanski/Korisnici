using System.Data.Entity;
using rs.mvc.Korisnici.Initializers;

namespace rs.mvc.Korisnici.Model
{
    public class DataContext : DbContext
    {

        static DataContext()
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());
            Database.SetInitializer(new DbInitializer());
        }

        public DataContext() : this("KorisniciConnection")
        {
        }

        public DataContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<Aplikacija> Aplikacije { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Log> LogoviKorisnika { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var aplikacija = modelBuilder.Entity<Aplikacija>();
            aplikacija.ToTable("Aplikacije");

            var korisnici = modelBuilder.Entity<Korisnik>();
            korisnici.ToTable("KorisnickiNalozi");

            var logovi = modelBuilder.Entity<Log>();
            logovi.ToTable("LogoviKorisnika");
        }
    }
}
using System.Data.Entity;

namespace rs.mvc.Korisnici.Model
{
    public class DataContext : DbContext
    {

        static DataContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DataContext>());
        }

        public DbSet<Aplikacija> Aplikacije { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var aplikacija = modelBuilder.Entity<Aplikacija>();
            aplikacija.ToTable("Aplikacije");

            var korisnici = modelBuilder.Entity<Korisnik>();
            korisnici.ToTable("KorisnickiNalozi");
        }
    }
}
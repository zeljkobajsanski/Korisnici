using System.Data.Entity;

namespace mvc.com.Korisnici.Model
{
    public class DataContext : DbContext
    {

        public DbSet<Aplikacija> Aplikacije { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var aplikacija = modelBuilder.Entity<Aplikacija>();
            aplikacija.ToTable("Aplikacije");
        }
    }
}
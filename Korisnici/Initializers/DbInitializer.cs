using System.Data.Entity;
using rs.mvc.Korisnici.Model;
using rs.mvc.Korisnici.Utils;

namespace rs.mvc.Korisnici.Initializers
{
    public class DbInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            base.Seed(context);
            context.Database.ExecuteSqlCommand(
                "ALTER TABLE KorisnickiNalozi ADD CONSTRAINT jedinstveno_korisnicko_ime UNIQUE (KorisnickoIme)");

            var adminApp = new Aplikacija
            {
                Kod = "admin",
                Naziv = "MVC admin",
                Logo = "adminApp.png",
                HomeUrl = "http://korisnici.azurewebsites.net"
            };
            context.Aplikacije.Add(adminApp);
            var oktopod = new Aplikacija
            {
                Kod = "rvms",
                Naziv = "Oktopod",
                Logo = "oktopod.png",
                HomeUrl = "http://rvms.azurewebsites.net"
            };
            context.Aplikacije.Add(oktopod);
            var zeks = new Korisnik
            {
                KorisnickoIme = "zeks",
                EMail = "zeljko.bajsanski@gmail.com",
                Ime = "Željko",
                Prezime = "Bajšanski",
                Administrator = true,
                Lozinka = HashUtils.GetHash("Z3ks_J0va"),
                Aktivan = true
            };
            zeks.Aplikacije.Add(adminApp);
            zeks.Aplikacije.Add(oktopod);
            context.Korisnici.Add(zeks);

            context.SaveChanges();
        }
    }
}
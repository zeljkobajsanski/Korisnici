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
            var oktopod = new Aplikacija
            {
                Kod = "rvms",
                Naziv = "Oktopod",
                Logo = "oktopod.png",
                HomeUrl = "http://rvms.azurewebsites.net"
            };
            var zeks = new Korisnik
            {
                KorisnickoIme = "zeks",
                EMail = "zeljko.bajsanski@gmail.com",
                Ime = "Željko",
                Prezime = "Bajšanski",
                Administrator = true,
                Lozinka = HashUtils.GetHash("1302"),
                Aplikacija = oktopod
            };
            context.Aplikacije.Add(oktopod);
            context.Korisnici.Add(zeks);

            context.SaveChanges();
        }
    }
}
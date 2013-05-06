using System;
using rs.mvc.Korisnici.Model;
using rs.mvc.Korisnici.Repository;
using rs.mvc.Korisnici.Services;

namespace rs.mvc.Korisnici.ConsoleAdmin
{
    class Program
    {
        private static ConsoleColor _foregroundColor;

        static void Main(string[] args)
        {
            _foregroundColor = Console.ForegroundColor;
            Console.WriteLine("Dobrodošli u administraciju korisnika");
            Console.WriteLine("Za spisak komandi unestite [pomoc]");
            Console.WriteLine("Za izlazak iz aplikacije unesite [kraj]");
            string command = null;
            while (command != "kraj")
            {
                command = Console.ReadLine();
                Process(command);
                Console.WriteLine();
                Console.WriteLine("Unesite komandu:");
            }
        }

        private static void Process(string command)
        {
            if (command == "kraj") return;
            if (command == "pomoc")
            {
                Help();
                return;
            }
            if (command == "aplikacije")
            {
                ListajAplikacije();
                return;
            }
            if (command.StartsWith("kreiraj-aplikaciju"))
            {
                KreirajAplikaciju(command);
                return;
            }
            if (command.StartsWith("kreiraj-korisnika"))
            {
                KreirajKorisnika(command);
                return;
            }
            if (command == "lista-korisnika")
            {
                ListajKorisnike();
                return;
            }
            if (command.StartsWith("korisnici-aplikacije"))
            {
                ListajKorisnikeAplikacije(command);
                return;
            }

            PrikaziGresku(command);
        }

        

        private static void ListajAplikacije()
        {
            try
            {
                using (var repo = new Repository<Aplikacija>())
                {
                    var aplikacije = repo.GetAll();
                    Console.WriteLine();
                    Console.WriteLine("Lista aplikacija");
                    Console.WriteLine("================");
                    foreach (var aplikacija in aplikacije)
                    {
                        Console.WriteLine(string.Format("{0} - {1}", aplikacija.Kod, aplikacija.Naziv));
                    }
                }
            }
            catch (Exception exc)
            {
                PrikaziGresku(exc);
            }
        }

        private static void KreirajAplikaciju(string command)
        {
            Console.WriteLine();
            Console.WriteLine("Kreiranje aplikacije");
            Console.WriteLine("====================");
            var parts = command.Split(' ');
            if (parts.Length != 3)
            {
                PrikaziGresku(command);
                return;
            }
            try
            {
                Aplikacije.KreirajAplikaciju(new Aplikacija()
                    {
                        Kod = parts[1],
                        Naziv = parts[2]
                    });
                Console.WriteLine("Aplikacija " + parts[2] + " je kreirana.");
            }
            catch (Exception exc)
            {
                PrikaziGresku(exc);
            }
        }

        private static void KreirajKorisnika(string command)
        {
            Console.WriteLine();
            Console.WriteLine("Kreiranje korisnika");
            Console.WriteLine("===================");
            var parts = command.Split(' ');
            if (parts.Length != 7 && parts.Length != 8)
            {
                PrikaziGresku(command);
                return;
            }
            var korisnik = new Korisnik
            {
                KorisnickoIme = parts[1],
                LozinkaPlain = parts[2],
                EMail = parts[3],
                Ime = parts[4],
                Prezime = parts[5],
                Administrator = parts[6] == "da",
            };
            try
            {
                Services.Korisnici.KreirajKorisnika(korisnik, parts.Length == 8 ? parts[7] : null);
                Console.WriteLine("Korisnik " + parts[1] + " je kreiran.");
            }
            catch (Exception exc)
            {
                PrikaziGresku(exc);
            }
        }

        public static void ListajKorisnike()
        {
            try
            {
                using (var repo = new Repository<Korisnik>())
                {
                    Console.WriteLine();
                    var korisnici = repo.GetAll();
                    Console.WriteLine("Lista korisnika");
                    Console.WriteLine("================");
                    foreach (var korisnik in korisnici)
                    {
                        Console.WriteLine(string.Format("{0} - {1} {2} ({3})", korisnik.KorisnickoIme, korisnik.Ime, korisnik.Prezime, korisnik.EMail));
                    }
                }
            }
            catch (Exception exc)
            {
                PrikaziGresku(exc);
            }
        }

        private static void ListajKorisnikeAplikacije(string command)
        {
            var parts = command.Split(' ');
            if (parts.Length != 2)
            {
                PrikaziGresku(command);
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Lista korisnika aplikacije");
            Console.WriteLine("==========================");
            try
            {
                var korisnici = Aplikacije.VratiKorisnike(parts[1]);
                foreach (var korisnik in korisnici)
                {
                    Console.WriteLine(string.Format("{0} - {1} {2} ({3})", korisnik.KorisnickoIme, korisnik.Ime, korisnik.Prezime, korisnik.EMail));
                }
            }
            catch (Exception exc)
            {
                PrikaziGresku(exc);
            }
        }

        private static void Help()
        {
            Console.WriteLine();
            Console.WriteLine("Pomoć");
            Console.WriteLine("================");
            Console.WriteLine("pomoc - spisak komandi");
            Console.WriteLine("kraj - kraj rada");
            Console.WriteLine("aplikacije - listing aplikacija");
            Console.WriteLine("kreiraj-aplikaciju [kod] [naziv aplikacije] - kreiranje nove aplikacije");
            Console.WriteLine("kreiraj-korisnika [korisničko ime] [lozinka] [e-mail] [ime] [prezime] [administrator(da/ne)] [kod aplikacije*]- kreiraj novog korisnika");
            Console.WriteLine("lista-korisnika - listing korisnika");
            Console.WriteLine("korisnici-aplikacije [kod aplikacije] - listing korisnika aplikacije");
        }

        private static void PrikaziGresku(Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Greška: " + exception);
            Console.ForegroundColor = _foregroundColor;
        }

        private static void PrikaziGresku(string command)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nepoznata komanda: " + command);
            Console.ForegroundColor = _foregroundColor;
        }
    }
}

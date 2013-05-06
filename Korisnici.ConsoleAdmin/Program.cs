using System;
using rs.mvc.Korisnici.Model;
using rs.mvc.Korisnici.Repository;

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
            }
        }

        private static void Process(string command)
        {
            if (command == "pomoc")
            {
                Help();
                return;
            }
            else if (command == "aplikacije")
            {
                ListajAplikacije();
                return;
            }
            if (command.StartsWith("kreiraj-aplikaciju"))
            {
                KreirajAplikaciju(command);
                return;
            }

            PrikaziGresku(command);
        }

        private static void KreirajAplikaciju(string command)
        {
            var parts = command.Split(' ');
            if (parts.Length != 2)
            {
                PrikaziGresku(command);
                return;
            }
        }

        private static void PrikaziGresku(string command)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nepoznata komanda: " + command);
            Console.ForegroundColor = _foregroundColor;
        }

        private static void ListajAplikacije()
        {
            using (var repo = new Repository<Aplikacija>())
            {
                var aplikacije = repo.GetAll();
                Console.WriteLine("Lista aplikacija");
                Console.WriteLine("================");
                foreach (var aplikacija in aplikacije)
                {
                    Console.WriteLine(string.Format("{0} - {1}", aplikacija.Kod, aplikacija.Naziv));
                }
            }
        }

        private static void Help()
        {
            Console.WriteLine("pomoc - spisak komandi");
            Console.WriteLine("kraj - kraj rada");
            Console.WriteLine("aplikacije - listing aplikacija");
            Console.WriteLine("kreiraj-aplikaciju [naziv aplikacije] - kreiranje nove aplikacije");
        }
    }
}

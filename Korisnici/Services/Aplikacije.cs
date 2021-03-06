﻿using System.Collections.Generic;
using rs.mvc.Korisnici.Model;
using rs.mvc.Korisnici.Repository;

namespace rs.mvc.Korisnici.Services
{
    public static class Aplikacije
    {
         public static void KreirajAplikaciju(Aplikacija aplikacija)
         {
             using (var r = new Repository<Aplikacija>())
             {
                 r.Add(aplikacija);
                 r.Save();
             }
         }

        public static IEnumerable<Korisnik> VratiKorisnike(string kodAplikacije)
        {
            using (var r = new AplikacijeRepository())
            {
                return r.VratiKorisnikeAplikacije(kodAplikacije);
            }
        }
    }
}
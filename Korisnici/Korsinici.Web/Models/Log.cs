using System;

namespace Korsinici.Web.Models
{
    public class Log
    {
        public string KorisnickoIme { get; set; }

        public string Aplikacija { get; set; }

        public DateTime DatumPrijave { get; set; }

        public DateTime VremePoslednjeAktivnosti { get; set; }
        
        public DateTime? VremeOdjave { get; set; }

        public string IpAdresa { get; set; }

        public string Browser { get; set; }

        public int VremeNeaktivnosti
        {
            get
            {
                if (VremeOdjave.HasValue) return 1000;
                return (int)DateTime.Now.Subtract(VremePoslednjeAktivnosti).TotalMinutes;
            }
        }
    }
}
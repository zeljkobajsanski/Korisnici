using System;
using System.ComponentModel.DataAnnotations;

namespace rs.mvc.Korisnici.Model
{
    public class Log : Entity
    {
        [Required]
        [StringLength(50)]
        public string KorisnickoIme { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Dozvoljena dužina naziva aplikacije je do 255 karaktera")]
        public string Aplikacija { get; set; }

        public DateTime DatumPrijave { get; set; }

        public DateTime VremePoslednjeAktivnosti { get; set; }

        public int VremeNeaktivnosti { get; set; }

        public string IpAdresa { get; set; }

        public string Browser { get; set; }

        public int PostaviVremeNeaktivnosti()
        {
            var now = DateTime.Now;
            VremeNeaktivnosti = (int)now.Subtract(VremePoslednjeAktivnosti).TotalSeconds;
            VremePoslednjeAktivnosti = now;
            return VremeNeaktivnosti;
        }

        
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace rs.mvc.Korisnici.Model
{
    public class Log : Entity
    {
        [Required]
        [StringLength(50)]
        public string KorisnickoIme { get; set; }

        public DateTime DatumPrijave { get; set; }

        public DateTime VremePoslednjeAktivnosti { get; set; }
    }
}
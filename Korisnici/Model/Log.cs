﻿using System;
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
    }
}
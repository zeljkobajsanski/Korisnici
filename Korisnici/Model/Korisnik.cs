using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rs.mvc.Korisnici.Model
{
    public class Korisnik : Entity
    {

        public Korisnik()
        {
            Aplikacije = new List<Aplikacija>();    
        }

        [Required(ErrorMessage = "Korisničko ime nije uneto")]
        [StringLength(50, ErrorMessage = "Dozvoljena dužina korisničkog imena je do 25 karaktera")]
        public string KorisnickoIme { get; set; }

        [Required(ErrorMessage = "Ime nije uneto")]
        [StringLength(50, ErrorMessage = "Dozvoljena dužina je do 25 karaktera")]
        public string Ime { get; set; }
        
        [Required(ErrorMessage = "Prezime nije uneto")]
        [StringLength(50, ErrorMessage = "Dozvoljena dužina je do 25 karaktera")]
        public string Prezime { get; set; }

        [Required(ErrorMessage = "E-mail nije unet")]
        [StringLength(255, ErrorMessage = "Dozvoljena dužina je do 255 karaktera")]
        [RegularExpression(@"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$", ErrorMessage = "E-mail je neispravan")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Lozinka nije uneta")]
        public byte[] Lozinka { get; set; }

        [NotMapped]
        public string LozinkaPlain { get; set; }

        public IList<Aplikacija> Aplikacije { get; set; }

        public bool Administrator { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace rs.mvc.Korisnici.Model
{
    public class Korisnik : Entity
    {
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

        public Aplikacija Aplikacija { get; set; }

        public int AplikacijaId { get; set; }

        public bool Administrator { get; set; }
    }
}
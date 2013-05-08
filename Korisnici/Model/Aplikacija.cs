using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace rs.mvc.Korisnici.Model
{
    public class Aplikacija : Entity
    {
        public Aplikacija()
        {
            Aktivan = true;
        }

        [Required(ErrorMessage = "Kod aplikacije nije unet")]
        [StringLength(5, ErrorMessage = "Dužina koda aplikacije je 5 karaktera")]
        public string Kod { get; set; }

        [Required(ErrorMessage = "Naziv aplikacije nije unet")]
        [StringLength(255, ErrorMessage = "Dozvoljena dužina naziva aplikacije je do 255 karaktera")]
        public string Naziv { get; set; }

        public string Logo { get; set; }

        public IList<Korisnik> Korisnici { get; set; }

        [Required(ErrorMessage = "Url aplikacije nije unet")]
        [StringLength(256, ErrorMessage = "Dužina url-a je najviše 256 karaktera")]
        public string HomeUrl { get; set; }
    }
}
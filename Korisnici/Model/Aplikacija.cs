using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mvc.com.Korisnici.Model
{
    public class Aplikacija : Entity
    {
        [Required(ErrorMessage = "Naziv aplikacije nije unet")]
        [StringLength(255, ErrorMessage = "Dozvoljena dužina naziva aplikacije je do 255 karaktera")]
        public string Naziv { get; set; }

        public IList<Korisnik> Korisnici { get; set; }
    }
}
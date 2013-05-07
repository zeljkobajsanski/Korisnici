using System.ComponentModel.DataAnnotations;

namespace Korsinici.Web.Models
{
    public class User
    {
        [Required(ErrorMessage = "Korisničko ime nije uneto")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Lozinka nije uneta")]
        public string Password { get; set; }

        public string Application { get; set; }
    }
}
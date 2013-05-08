using rs.mvc.Korisnici.Model;

namespace Korsinici.Web.ViewModels
{
    public class RegisterViewModel
    {
        public string ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public string Logo { get; set; }
        public Korisnik Korisnik { get; set; } 
    }
}
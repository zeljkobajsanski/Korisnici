using Korsinici.Web.Models;

namespace Korsinici.Web.ViewModels
{
    public class LoginViewModel
    {
        public string ApplicationName { get; set; }
        public string Logo { get; set; }
        public string ApplicationCode { get; set; }
        public User User { get; set; } 
    }
}
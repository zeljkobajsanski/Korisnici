namespace Korsinici.Web.Models
{
    public class Login
    {
        public string Status { get; set; }
        public string StatusMessage { get; set; }
        public int LogId { get; set; }
        public int IdKorisnika { get; set; }
        public string KorisnickoIme { get; set; }
        public string ImeIPrezime { get; set; }
    }
}
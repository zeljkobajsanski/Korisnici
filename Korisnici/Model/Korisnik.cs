namespace mvc.com.Korisnici.Model
{
    public class Korisnik : Entity
    {
        public string KorisnickoIme { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string EMail { get; set; }
    }
}
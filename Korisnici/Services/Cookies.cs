using System.Web;
using System.Web.Script.Serialization;
using rs.mvc.Korisnici.Utils;

namespace rs.mvc.Korisnici.Services
{
    public static class Cookies
    {
        public static KorisnikCookie VratiKorisnikaIzKukija(HttpRequestBase httpRequest)
        {
            var httpCookie = httpRequest.Cookies["korisnici_korisnik"];
            var korisnikCookie = httpCookie;
            if (korisnikCookie != null)
            {
                var jss = new JavaScriptSerializer();
                var korisnik = jss.Deserialize<KorisnikCookie>(korisnikCookie.Value);
                return korisnik;

            }
            return null;
        }
    }
}
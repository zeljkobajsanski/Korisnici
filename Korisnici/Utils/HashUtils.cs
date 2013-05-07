using System.Security.Cryptography;
using System.Text;

namespace rs.mvc.Korisnici.Utils
{
    public static class HashUtils
    {
        public static byte[] GetHash(string lozinkaPlain)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.Unicode.GetBytes(lozinkaPlain);
            byte[] hash = md5.ComputeHash(inputBytes);
            return hash;
        }
    }
}
using System.Net;

namespace Korisnici.ClientLibrary
{
    public class Account
    {
        private readonly string m_AuthServiceUrl;

        public Account(string authServiceUrl)
        {
            m_AuthServiceUrl = authServiceUrl;
        }

        public LogInfo Login(string userName, string password, string appCode)
        {
            var client = new WebClient();
            client.Headers["Content-Type"] = "application/x-www-form-urlencoded";
            var parameters = string.Format("Username={0}&Password={1}&Application={2}", userName, password, appCode);
            try
            {
                var response = client.UploadString(m_AuthServiceUrl + "/Account/LoginFromWindowsApp", "POST", parameters);
                var logInfo = response.Split('|');
                return new LogInfo
                           {
                               Status = logInfo[0],
                               Message = logInfo[1],
                               LogId = int.Parse(logInfo[2]),
                               Username = logInfo[3],
                               FirstName = logInfo[4],
                           };
            }
            catch (System.Exception exc)
            {
                throw;
            }
            return null;
        }

        public void Logout(int logId)
        {
            var client = new WebClient();
            client.Headers["Content-Type"] = "application/x-www-form-urlencoded";
            var parameters = string.Format("idLoga={0}", logId);
            client.UploadString(m_AuthServiceUrl + "/Account/Logout", "POST", parameters);
        }
    }
}
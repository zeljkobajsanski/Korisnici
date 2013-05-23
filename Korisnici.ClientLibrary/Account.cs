using System;
using System.Net;
using System.Web.Script.Serialization;

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
                var jss = new JavaScriptSerializer();
                var logInfo = jss.Deserialize<LogInfo>(response);
                return logInfo;
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
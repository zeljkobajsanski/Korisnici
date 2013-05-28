using System.Net;
using System.ServiceModel;
using Korisnici.ClientLibrary.WebServices.AccountsService;

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
            try
            {
                using (var svc = GetService())
                {
                    var loginInfo = svc.Login(userName, password, appCode);
                    return new LogInfo
                    {
                        Status = loginInfo.Status,
                        Message = loginInfo.StatusMessage,
                        LogId = loginInfo.LogId,
                        UserId = loginInfo.IdKorisnika,
                        Username = loginInfo.KorisnickoIme,
                        Name = loginInfo.ImeIPrezime
                    };
                }
            }
            catch (System.Exception exc)
            {
                return new LogInfo {Status = "Error", Message = exc.Message};
            }
        }

        private AccountsServiceClient GetService()
        {
            return new AccountsServiceClient(new BasicHttpBinding(), new EndpointAddress(m_AuthServiceUrl + "/AccountsService.svc"));
        }

        public void Logout(int logId)
        {
            using (var svc = GetService())
            {
                svc.Logout(logId);
            }
        }

        public Korisnik GetUserInfo(int id)
        {
            using (var svc = GetService())
            {
                return svc.GetUserInfo(id);
            }
        }

        public void Save(Korisnik korisnik)
        {
            using (var svc = GetService())
            {
                svc.Save(korisnik);
            }
        }

        public void ChangePassword(int userId, string password)
        {
            using (var svc = GetService())
            {
                svc.ChangePassword(userId, password);
            }
        }
    }
}
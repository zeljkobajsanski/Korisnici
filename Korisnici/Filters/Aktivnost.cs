using System;
using System.Web.Mvc;
using System.Web.Security;
using rs.mvc.Korisnici.Repository;

namespace rs.mvc.Korisnici.Filters
{
    public class Aktivnost : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var cookie = filterContext.HttpContext.Request.Cookies[FormsAuthentication.FormsCookieName];
            if (cookie == null) return;
            var value = cookie.Value;
            var ticket = FormsAuthentication.Decrypt(value);
            if (ticket == null) return;
            var userData = ticket.UserData;
            var logId = int.Parse(userData);
            using (var r = new LogoviKorisnikaRepository())
            {
                var log = r.Get(logId);
                log.VremePoslednjeAktivnosti = DateTime.Now;
                r.Save();
            }
        }
    }
}
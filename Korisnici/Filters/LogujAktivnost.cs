using System;
using System.Web.Mvc;
using System.Web.Security;
using rs.mvc.Korisnici.Repository;

namespace rs.mvc.Korisnici.Filters
{
    public class LogujAktivnost : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var cookie = filterContext.HttpContext.Request.Cookies["korisnici_idLoga"];
            if (cookie == null) return;
            var value = cookie.Value;
            var logId = int.Parse(value);
            using (var r = new LogoviKorisnikaRepository())
            {
                var log = r.Get(logId);
                if (log != null)
                {
                    log.VremePoslednjeAktivnosti = DateTime.Now;
                    r.Save();
                }
            }
        }
    }
}
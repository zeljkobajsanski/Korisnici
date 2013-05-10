using System;
using System.Web.Mvc;
using System.Web.Security;
using NLog;
using rs.mvc.Korisnici.Repository;

namespace rs.mvc.Korisnici.Filters
{
    public class LogujAktivnost : FilterAttribute, IActionFilter
    {
        private static readonly Logger SLogger = LogManager.GetCurrentClassLogger();

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            try
            {
                var cookie = filterContext.HttpContext.Request.Cookies["korisnici_idLoga"];
                if (cookie == null)
                {
                    SLogger.Warn("Ne mogu da pronađem cookie: korisnici_idLoga");
                    return;
                }
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
            catch (Exception exc)
            {
                SLogger.ErrorException("OnActionExecuted", exc);
            }
        }
    }
}
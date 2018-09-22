using Microsoft.AspNetCore.Mvc.Filters;
using ZFine.Code;

namespace ZFine.Web
{
    public class HandlerLoginAttribute : ActionFilterAttribute
    {
        public bool Ignore = true;
        public HandlerLoginAttribute(bool ignore = true)
        {
            Ignore = ignore;
        }

        public void OnAuthorization(AuthorizationFilterContext filterContext)
        {

            if (Ignore == false)
            {
                return;
            }
            if (OperatorProvider.Provider.GetCurrent() == null)
            {
                WebHelper.WriteCookie("ZFine_login_error", "overdue");
                filterContext.HttpContext.Response.Redirect("/Login/Index");
                return;
            }
        }

        
    }
}
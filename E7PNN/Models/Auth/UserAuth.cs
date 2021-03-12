using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E7PNN.Server;

namespace E7PNN.Models.Auth
{
    public class UserAuthFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var tokenCookie = filterContext.HttpContext.Request
                .Cookies[LoginDbTool.CookieName];

            if (tokenCookie == null)
            {
                this.setError(filterContext);
            }
            else
            {
                using (var db = new E7pnnContext())
                {
                    var service = new LoginDbTool(db);
                    var acc = service.checkToken(tokenCookie.Value);
                    if (string.IsNullOrEmpty(acc))
                    {
                        this.setError(filterContext);
                    }
                }
            }


            base.OnActionExecuting(filterContext);
        }
        private void setError(ActionExecutingContext filterContext)
        {
            filterContext.Result = new RedirectResult("/Lonig/Login");
        }
    }
}
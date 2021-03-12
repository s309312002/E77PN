using E7PNN.Models;
using E7PNN.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E7PNN.Areas.Admin.Models.Auth
{
    public class AdminLogin: ActionFilterAttribute
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
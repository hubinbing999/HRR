using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Filters
{
    public class DlFilterAttibute: ActionFilterAttribute
    {
       
            public override void OnActionExecuted(ActionExecutedContext filterContext)
            {
                if (filterContext.HttpContext.Session["user"] == null)
                {
                    filterContext.HttpContext.Response.Redirect("/usser/Login");
                }
            }
        
    }
}
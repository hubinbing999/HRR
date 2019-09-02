using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Filters
{
    public class engage_resumeAttibute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.HttpContext.Session["eid"]==null)
            {
                filterContext.HttpContext.Response.Redirect("/engage_major_release/position_change_update1");
            }
        }
    }
}
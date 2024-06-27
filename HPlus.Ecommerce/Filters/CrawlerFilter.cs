using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication11.Filters
{
    public class CrawlerFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Request.Browser.Crawler)
            {
                filterContext.Result = new HttpNotFoundResult();
            }
        }
    }
}
using System.Net;
using System.Web.Mvc;

namespace WebApplication11.Filters
{
    public class CustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            var bytes = System.IO.File.ReadAllBytes(filterContext.HttpContext.Server.MapPath("/error/500.html"));
            filterContext.Result = new FileContentResult(bytes, "text/html");
            filterContext.ExceptionHandled = true;
        }
    }
}
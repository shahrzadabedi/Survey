using Survey.WebAPI.Filters;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.Mvc;

namespace Survey.WebAPI
{
    public class FilterConfig
    {  
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());         
        }
        public static void RegisterHttpFilters(HttpFilterCollection filters)
        {            
            filters.Add(new LoggingFiterAttribute());
        }
    }
}

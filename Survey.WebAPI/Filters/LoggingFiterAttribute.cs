using Microsoft.Ajax.Utilities;
using NLog;
using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.WebPages;

namespace Survey.WebAPI.Filters
{
    public class LoggingFiterAttribute : ActionFilterAttribute
    {
        
        ISurveyLog Log; 
        public LoggingFiterAttribute()
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            this.Log = new SurveyLog(logger);
        }
        public override async Task OnActionExecutingAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            
            //string userName = ((System.Security.Principal.GenericPrincipal)Thread.CurrentPrincipal).Identity.Name;
            //GlobalDiagnosticsContext.Set("user", userName);
                      
            Log.InitiateService(actionContext.Request);
            await Log.Log(actionContext);
        }
        public override async Task OnActionExecutedAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            //string userName = ((System.Security.Principal.GenericPrincipal)Thread.CurrentPrincipal).Identity.Name;
            //GlobalDiagnosticsContext.Set("user", userName);
           
            await Log.Log(actionExecutedContext);
            Log.EndService(actionExecutedContext.Request);
        }
    }

}
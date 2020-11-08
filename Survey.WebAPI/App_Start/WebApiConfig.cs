using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Linq;
using System.Web.Http;
using SimpleInjector;
using Survey.Business;
using Survey.WebAPI.Filters;

namespace Survey.WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            // config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/GetAll",
            //    defaults: new { id = RouteParameter.Optional }
            //);
            // StructuremapWebApi.Start();
            // 1. Create a new Simple Injector container
            //Container container = new Container();

            // 2. Configure the container (register)
            //container.Register<ISurveyService, SurveyService>();
            

            // 3. Verify your configuration
            //container.Verify();
          //config.Filters .Add(BasicAuthenticationAttribute)
        }
    }
}

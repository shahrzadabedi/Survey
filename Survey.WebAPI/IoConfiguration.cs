using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Survey.Business;
using System.Web.Http;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;

namespace Survey.WebAPI
{
    public static class IoCConfiguration
    {
        public static void Config()
        {
            Container container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            IoCInitializer initializer = new IoCInitializer();
            initializer.Initialize(container);            

            // This is an extension method from the integration package.
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}
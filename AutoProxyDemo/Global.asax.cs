using System.Collections.Generic;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AutoProxyDemo
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Example of configuration by code
            //var config = new AutoProxy.AutoProxyConfiguration
            //{
            //    LibraryConfiguration = new AutoProxy.Library
            //    {
            //        Compress = false,
            //        Namespace = "AutoProxyDemo",
            //        Output = "~/Scripts/proxy/autoproxy.min.js",
            //        IncludeFiles = new List<AutoProxy.File> { new AutoProxy.File { Src = "~/Scripts/proxy/autoproxy.core.js" } },
            //        Controllers = new List<AutoProxy.Controller> { new AutoProxy.Controller { Name = "OrdersController" } }
            //    }
            //};

            var generator = new AutoProxy.ProxyGenerator();
            generator.ResolveProxies();
        }
    }
}
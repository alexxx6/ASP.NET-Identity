using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using App.App_Start;
using Data;
using Data.Migrations;

namespace App
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(
                   new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());

            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ViewEngineConfig.RegisterViewEngines(ViewEngines.Engines);
            MappingConfig.RegisterMaps();
        }
    }
}

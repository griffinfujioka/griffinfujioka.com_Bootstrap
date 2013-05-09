using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BootstrapMvcSample.Controllers;
using NavigationRoutes;
using griffinfujioka_Boostrap.Controllers;

namespace BootstrapMvcSample
{
    public class ExampleLayoutsRouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapNavigationRoute<HomeController>("Home", c => c.Index());
            routes.MapNavigationRoute<PageController>("About", c => c.About(), "");

            routes.MapNavigationRoute<PageController>("Portfolio", c => c.Portfolio(), "");

            routes.MapNavigationRoute<PageController>("Contact", c => c.Contact(), "");

            routes.MapNavigationRoute<PageController>("Resume", c => c.Resume(), "");

            //routes.MapNavigationRoute<ExampleLayoutsController>("home", c => c.HomePage(), "");

            //routes.MapNavigationRoute<ExampleLayoutsController>("About", c => c.About(), "");

            //routes.MapNavigationRoute<ExampleLayoutsController>("Portfolio", c => c.Portfolio(), "");

            //routes.MapNavigationRoute<ExampleLayoutsController>("Contact", c => c.Contact(), "");

            //routes.MapNavigationRoute<ExampleLayoutsController>("Resume", c => c.Resume(), "");

            //routes.MapNavigationRoute<ExampleLayoutsController>("Example Layouts", c => c.Starter())
            //      .AddChildRoute<ExampleLayoutsController>("Marketing", c => c.Marketing())
            //      .AddChildRoute<ExampleLayoutsController>("Fluid", c => c.Fluid())
            //      .AddChildRoute<ExampleLayoutsController>("Sign In", c => c.SignIn())
            //    ;
        }
    }
}

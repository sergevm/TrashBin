using System.Web.Mvc;
using System.Web.Routing;

namespace TrashBin.Mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Per the docs, the hub route should be registered before all other route registrations!
            RouteTable.Routes.MapHubs();

            routes.MapRoute(
                "Default", 
                "{controller}/{action}/{id}", 
                new
                    {
                        controller = "Project", 
                        action = "Index", 
                        id = UrlParameter.Optional
                    }
            );
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHost.server.Configurations
{
    public class RouteConfig
    {
        public static void RegisterRoute(HttpConfiguration route)
        {
            route.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controllers}/{id}",
                defaults: new {id= RouteParameter.Optional});
        }
    }
}

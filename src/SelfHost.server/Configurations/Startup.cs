using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;
using SelfHost.server.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHost.server
{
    public partial class Startup
    {
        public void InitiateConfig(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            RouteConfig.RegisterRoute(config);

            app.UseCors(CorsOptions.AllowAll);

            app.Map("/signalr", map =>
            {
                HubConfiguration hcf = new HubConfiguration();
                map.RunSignalR();
            });

            app.UseWebApi(config);
        }
    }
}

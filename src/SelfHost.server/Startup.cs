using Microsoft.Owin;
using Owin;
using SelfHost.server;

[assembly: OwinStartup(typeof(Startup))]
namespace SelfHost.server
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            InitiateConfig(app);
        }
    }
}

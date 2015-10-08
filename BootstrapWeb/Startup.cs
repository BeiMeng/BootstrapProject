using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapWeb.Startup))]
namespace BootstrapWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

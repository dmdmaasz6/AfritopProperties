using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AfritopProperties.Startup))]
namespace AfritopProperties
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

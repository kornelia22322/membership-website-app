using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MembershipsApp.Startup))]
namespace MembershipsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

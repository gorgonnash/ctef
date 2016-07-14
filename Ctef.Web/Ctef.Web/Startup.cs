using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ctef.Web.Startup))]
namespace Ctef.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

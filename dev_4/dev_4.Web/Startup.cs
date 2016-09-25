using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dev_4.Web.Startup))]
namespace dev_4.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

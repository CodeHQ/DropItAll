using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DropItAll.Web.Startup))]
namespace DropItAll.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

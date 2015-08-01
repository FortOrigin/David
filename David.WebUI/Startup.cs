using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(David.WebUI.Startup))]
namespace David.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

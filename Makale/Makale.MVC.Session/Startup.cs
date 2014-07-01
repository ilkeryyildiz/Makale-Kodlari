using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Makale.MVC.Session.Startup))]
namespace Makale.MVC.Session
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

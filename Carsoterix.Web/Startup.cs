using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Carsoterix.Web.Startup))]
namespace Carsoterix.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

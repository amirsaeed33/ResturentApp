using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResturantApplication.Startup))]
namespace ResturantApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

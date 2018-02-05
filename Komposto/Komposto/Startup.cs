using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Komposto.Startup))]
namespace Komposto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

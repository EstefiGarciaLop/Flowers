using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Flowers.Startup))]
namespace Flowers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

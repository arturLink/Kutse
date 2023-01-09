using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kutse.Startup))]
namespace Kutse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

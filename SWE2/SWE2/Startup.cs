using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SWE2.Startup))]
namespace SWE2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAspRaeSaraJones.Startup))]
namespace WebAspRaeSaraJones
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

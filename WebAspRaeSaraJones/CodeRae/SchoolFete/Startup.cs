using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolFete.Startup))]
namespace SchoolFete
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Markert.Startup))]
namespace Markert
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

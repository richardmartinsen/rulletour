using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rulletour.Startup))]
namespace Rulletour
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

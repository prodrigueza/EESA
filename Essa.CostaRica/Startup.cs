using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Essa.CostaRica.Startup))]
namespace Essa.CostaRica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

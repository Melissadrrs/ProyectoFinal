using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eventos.Mvc.Startup))]
namespace Eventos.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

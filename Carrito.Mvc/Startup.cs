using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Carrito.Mvc.Startup))]
namespace Carrito.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

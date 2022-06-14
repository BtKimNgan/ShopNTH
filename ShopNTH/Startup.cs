using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopNTH.Startup))]
namespace ShopNTH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

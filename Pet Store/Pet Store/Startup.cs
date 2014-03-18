using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pet_Store.Startup))]
namespace Pet_Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcStoreMusic.Startup))]
namespace MvcStoreMusic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

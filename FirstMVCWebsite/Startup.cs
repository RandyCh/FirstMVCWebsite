using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstMVCWebsite.Startup))]
namespace FirstMVCWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

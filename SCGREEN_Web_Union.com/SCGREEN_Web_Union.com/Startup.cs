using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SCGREEN_Web_Union.com.Startup))]
namespace SCGREEN_Web_Union.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSC205_Madeira.Startup))]
namespace CSC205_Madeira
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

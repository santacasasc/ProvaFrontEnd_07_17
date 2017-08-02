using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProvaFrontEnd_07_17.Startup))]
namespace ProvaFrontEnd_07_17
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

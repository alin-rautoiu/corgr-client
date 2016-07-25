using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Corgr_Client.Startup))]
namespace Corgr_Client
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

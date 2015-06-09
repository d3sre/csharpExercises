using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L11M1A.Startup))]
namespace L11M1A
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

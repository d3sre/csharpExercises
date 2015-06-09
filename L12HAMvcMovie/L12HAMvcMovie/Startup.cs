using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L12HAMvcMovie.Startup))]
namespace L12HAMvcMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

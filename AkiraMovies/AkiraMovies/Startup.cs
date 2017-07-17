using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AkiraMovies.Startup))]
namespace AkiraMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

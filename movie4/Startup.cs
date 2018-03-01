using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(movie4.Startup))]
namespace movie4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

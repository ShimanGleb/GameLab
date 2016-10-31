using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameLab.Startup))]
namespace GameLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

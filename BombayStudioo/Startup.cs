using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BombayStudioo.Startup))]
namespace BombayStudioo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

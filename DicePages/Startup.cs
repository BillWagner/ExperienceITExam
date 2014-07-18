using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DicePages.Startup))]
namespace DicePages
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

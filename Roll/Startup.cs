using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Roll.Startup))]
namespace Roll
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

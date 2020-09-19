using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ikub2.Startup))]
namespace Ikub2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

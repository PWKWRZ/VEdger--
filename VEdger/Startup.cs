using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VEdger.Startup))]
namespace VEdger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(crmverif.Startup))]
namespace crmverif
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

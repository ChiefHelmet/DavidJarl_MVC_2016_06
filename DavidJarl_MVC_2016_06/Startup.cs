using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DavidJarl_MVC_2016_06.Startup))]
namespace DavidJarl_MVC_2016_06
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

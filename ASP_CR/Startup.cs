using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_CR.Startup))]
namespace ASP_CR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

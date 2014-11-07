using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinanceDashboard.Startup))]
namespace FinanceDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

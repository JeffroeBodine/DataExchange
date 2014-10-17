using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataExchange.Startup))]
namespace DataExchange
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

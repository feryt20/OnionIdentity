using Microsoft.Owin;
using OnionIdentity.Web;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace OnionIdentity.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //important
            ConfigureAutofac(app);
            ConfigureAuth(app);
        }
    }
}

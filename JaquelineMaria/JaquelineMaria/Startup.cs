using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JaquelineMaria.Startup))]
namespace JaquelineMaria
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

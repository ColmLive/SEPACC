using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEPACC.Startup))]
namespace SEPACC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

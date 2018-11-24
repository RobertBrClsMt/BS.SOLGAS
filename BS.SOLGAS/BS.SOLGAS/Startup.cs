using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BS.SOLGAS.Startup))]
namespace BS.SOLGAS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

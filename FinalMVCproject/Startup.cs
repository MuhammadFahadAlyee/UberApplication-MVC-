using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalMVCproject.Startup))]
namespace FinalMVCproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

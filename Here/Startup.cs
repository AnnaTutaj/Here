using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Here.Startup))]
namespace Here
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2doparc.Startup))]
namespace _2doparc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

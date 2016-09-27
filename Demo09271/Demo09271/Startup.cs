using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo09271.Startup))]
namespace Demo09271
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

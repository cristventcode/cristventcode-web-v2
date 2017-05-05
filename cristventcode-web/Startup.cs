using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cristventcode_web.Startup))]
namespace cristventcode_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

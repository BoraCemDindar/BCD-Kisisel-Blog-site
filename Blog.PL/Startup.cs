using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blog.PL.Startup))]
namespace Blog.PL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

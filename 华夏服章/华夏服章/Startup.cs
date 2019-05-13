using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(华夏服章.Startup))]
namespace 华夏服章
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

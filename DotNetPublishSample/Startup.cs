using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetPublishSample.Startup))]
namespace DotNetPublishSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

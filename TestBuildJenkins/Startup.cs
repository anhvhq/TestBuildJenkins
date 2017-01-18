using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestBuildJenkins.Startup))]
namespace TestBuildJenkins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

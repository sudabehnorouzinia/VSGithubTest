using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSGithubTest.Startup))]
namespace VSGithubTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YouthSignUp.Startup))]
namespace YouthSignUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

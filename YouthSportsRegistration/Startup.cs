using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YouthSportsRegistration.Startup))]
namespace YouthSportsRegistration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

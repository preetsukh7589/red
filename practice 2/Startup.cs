using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(practice_2.Startup))]
namespace practice_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

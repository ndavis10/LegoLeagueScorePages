using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LegoLeagueScorePages.Startup))]
namespace LegoLeagueScorePages
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScholarSnappPOC.Startup))]
namespace ScholarSnappPOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

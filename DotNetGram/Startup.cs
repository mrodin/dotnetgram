using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetGram.Startup))]
namespace DotNetGram
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

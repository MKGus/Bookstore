using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NIIT.BookStore.web.Startup))]
namespace NIIT.BookStore.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

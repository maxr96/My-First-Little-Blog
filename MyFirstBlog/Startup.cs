using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstBlog.Startup))]
namespace MyFirstBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

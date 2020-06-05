using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DongTuanAnh_Lab_456.Startup))]
namespace DongTuanAnh_Lab_456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

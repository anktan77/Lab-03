using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenDaoDuyTan_1811063479_Lab03.Startup))]
namespace NguyenDaoDuyTan_1811063479_Lab03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

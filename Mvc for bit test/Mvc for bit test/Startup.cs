using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc_for_bit_test.Startup))]
namespace Mvc_for_bit_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalculatorClientApp.Startup))]
namespace CalculatorClientApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

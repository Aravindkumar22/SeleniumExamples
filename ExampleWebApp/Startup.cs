using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExampleWebApp.Startup))]
namespace ExampleWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E7PNN.Startup))]
namespace E7PNN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

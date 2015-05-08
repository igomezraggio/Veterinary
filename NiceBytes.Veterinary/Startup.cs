using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NiceBytes.Veterinary.Startup))]
namespace NiceBytes.Veterinary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

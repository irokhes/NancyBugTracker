using Owin;

namespace NancyBugTracker.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}
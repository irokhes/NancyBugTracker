using Nancy;

namespace NancyBugTracker
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => "Hello World Nancy";

        }
    }
}
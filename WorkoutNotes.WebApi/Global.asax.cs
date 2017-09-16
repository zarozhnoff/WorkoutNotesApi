using System.Web;
using System.Web.Http;
using WorkoutNotesApi;

namespace WorkoutNotes.WebApi
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            UnityConfig.RegisterComponents();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
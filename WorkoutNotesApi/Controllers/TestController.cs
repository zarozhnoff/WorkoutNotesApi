using System.Web.Http;

namespace WorkoutNotesApi.Controllers
{
    public class TestController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok();
        }
    }
}
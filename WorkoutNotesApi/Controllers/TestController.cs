using System.Web.Http;
using WorkoutNotesApi.DAL.Interfaces;

namespace WorkoutNotesApi.Controllers
{
    public class TestController : ApiController
    {
        private readonly IApplicationUnitOfWorkFactory _unitOfWorkFactory;


        public TestController(IApplicationUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public IHttpActionResult Get()
        {
            using (var applicationUnitOfWork = _unitOfWorkFactory.Create())
            {
                return Ok("hello world");
            }
        }
    }
}
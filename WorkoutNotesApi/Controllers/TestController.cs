using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using WorkoutNotesApi.DAL.Interfaces;
using WorkoutNotesApi.DomainModel.Entities;

namespace WorkoutNotesApi.Controllers
{
    public class TestController : ApiController
    {
        private readonly IApplicationUnitOfWorkFactory _unitOfWorkFactory;


        public TestController(IApplicationUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }


        public async Task<IHttpActionResult> Get()
        {
            using (var applicationUnitOfWork = _unitOfWorkFactory.Create())
            {
                var userRepository = applicationUnitOfWork.GetRepository<User>();
                var user = await userRepository.GetAllAsync();

                return Ok(user.First().FirstName);
            }
        }
    }
}
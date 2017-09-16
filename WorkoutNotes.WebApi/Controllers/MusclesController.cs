using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using WorkoutNotes.DomainModel.Entities;
using WorkoutNotes.Foundation.Muscles;
using WorkoutNotes.WebApi.Controllers.DataContracts;

namespace WorkoutNotes.WebApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class MusclesController : ApiController
    {
        private readonly IMuscleTrackingService _muscleTrackingService;


        public MusclesController(IMuscleTrackingService muscleTrackingService)
        {
            _muscleTrackingService = muscleTrackingService;
        }


        // GET: api/Muscles
        public async Task<IHttpActionResult> GetMuscles()
        {
            var muscles = await _muscleTrackingService.GetMusclesAsync();
            var musclesDataContracts = muscles.Select(CreateFrom).ToList();

            return Json(musclesDataContracts);
        }


        private static MuscleDataContract CreateFrom(Muscle muscle)
        {
            return new MuscleDataContract
            {
                Id = muscle.ExternalId,
                Name = muscle.Name.Translations.First().Value,
                SortOrder = muscle.SortOrder
            };
        }
    }
}
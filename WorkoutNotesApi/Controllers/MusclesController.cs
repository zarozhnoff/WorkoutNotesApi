using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using WorkoutNotesApi.DomainModel.Entities;
using WorkoutNotesApi.Foundation.Interfaces;

namespace WorkoutNotesApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
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
            var musclesDto = muscles.Select(CreateFrom);
            return Json(musclesDto);
        }


        private static object CreateFrom(Muscle muscle)
        {
            var name = muscle.Name.Translations.ElementAt(0).Value;
            return new {Id = muscle.Id, Name = name, SortOrder = muscle.SortOrder };
        }
    }
}
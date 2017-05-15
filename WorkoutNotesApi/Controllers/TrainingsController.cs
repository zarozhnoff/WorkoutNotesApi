using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using WorkoutNotesApi.DomainModel.Entities;
using WorkoutNotesApi.Foundation.Interfaces;

namespace WorkoutNotesApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TrainingsController : ApiController
    {
        private readonly ITrainingTrackingService _trainingTrackingService;


        public TrainingsController(ITrainingTrackingService trainingTrackingService)
        {
            _trainingTrackingService = trainingTrackingService;
        }


        // GET: api/Trainings
        public async Task<IHttpActionResult> GetTrainings()
        {
            var trainings = await _trainingTrackingService.GetTrainingsAsync();

            return Json(trainings);
        }

        // GET: api/Trainings/5
        public async Task<IHttpActionResult> GetTraining(Guid id)
        {
            var training = await _trainingTrackingService.GetTrainingAsync(id);
            if (training == null)
            {
                return NotFound();
            }

            return Json(training);
        }

        // PUT: api/Trainings/5
        public IHttpActionResult UpdateTraining(Guid id, Training training)
        {
            return Ok();
        }

        // POST: api/Trainings
        [HttpPost]
        public async Task<IHttpActionResult> PostTraining(Training training)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //var newTraining = await _trainingTrackingService.CreateTrainingAsync(training);

            //return Json(newTraining);

            return Ok();
        }

        // DELETE: api/Trainings/5
        public async Task<IHttpActionResult> DeleteTraining(Guid id)
        {
            var result = await _trainingTrackingService.DeleteTrainingAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using WorkoutNotes.DomainModel.Entities;
using WorkoutNotes.Foundation.Trainings;
using WorkoutNotes.WebApi.Controllers.DataContracts;

namespace WorkoutNotes.WebApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class TrainingsController : ApiController
    {
        private readonly ITrainingTrackingService _trainingTrackingService;


        public TrainingsController(ITrainingTrackingService trainingTrackingService)
        {
            _trainingTrackingService = trainingTrackingService;
        }


        [HttpGet]
        public async Task<IHttpActionResult> GetTrainings()
        {
            var trainings = await _trainingTrackingService.GetTrainingsAsync();

            return Json(trainings);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetTraining(Guid id)
        {
            var training = await _trainingTrackingService.GetTrainingAsync(id);
            if (training == null)
            {
                return NotFound();
            }

            return Json(training);
        }

        [HttpPut]
        public IHttpActionResult UpdateTraining(Guid id, TrainingDataContract training)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IHttpActionResult> CreateTraining(TrainingDataContract training)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var entity = CreateFrom(training);
            var creationResult = await _trainingTrackingService.CreateTrainingAsync(entity);

            return Ok();
        }

        public async Task<IHttpActionResult> DeleteTraining(Guid id)
        {
            var result = await _trainingTrackingService.DeleteTrainingAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return Ok();
        }

        private static Training CreateFrom(TrainingDataContract dataContract)
        {
            return new Training
            {
                Date = dataContract.Date,
                Comment = dataContract.Comment
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WorkoutNotesApi.DomainModel.Entities;
using WorkoutNotesApi.Foundation.Interfaces;

namespace WorkoutNotesApi.Controllers
{
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
        [ResponseType(typeof(Training))]
        public IHttpActionResult GetTraining(Guid id)
        {
            return Ok();
        }

        // PUT: api/Trainings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTraining(Guid id, Training training)
        {
            return Ok();
        }

        // POST: api/Trainings
        [ResponseType(typeof(Training))]
        public IHttpActionResult PostTraining(Training training)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }

        // DELETE: api/Trainings/5
        [ResponseType(typeof(Training))]
        public IHttpActionResult DeleteTraining(Guid id)
        {
            return Ok();
        }
    }
}
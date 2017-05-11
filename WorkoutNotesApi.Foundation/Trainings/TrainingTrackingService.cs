using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkoutNotesApi.DAL.Interfaces;
using WorkoutNotesApi.DomainModel.Entities;
using WorkoutNotesApi.Foundation.Interfaces;

namespace WorkoutNotesApi.Foundation.Trainings
{
    public class TrainingTrackingService : ITrainingTrackingService
    {
        private readonly IApplicationUnitOfWorkFactory _uowFactory;


        public TrainingTrackingService(IApplicationUnitOfWorkFactory uowFactory)
        {
            _uowFactory = uowFactory;
        }


        public async Task<IReadOnlyCollection<Training>> GetTrainingsAsync()
        {
            using (var uow = _uowFactory.Create())
            {
                var repository = uow.GetRepository<Training>();

                return await repository.GetAllAsync();
            }
        }

        public Task<Training> GetTrainingAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task CreateTrainingAsync(Training training)
        {
            throw new NotImplementedException();
        }
    }
}
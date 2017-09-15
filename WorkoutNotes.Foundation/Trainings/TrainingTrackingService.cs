using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutNotesApi.DAL.Interfaces;
using WorkoutNotesApi.DomainModel.Entities;

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

        public async Task<TrainingCreationResult> CreateTrainingAsync(Training training)
        {
            training.CreationDate = DateTime.UtcNow;

            using (var uow = _uowFactory.Create())
            {
                var repository = uow.GetRepository<Training>();
                repository.Add(training);

                await uow.SaveChangesAsync();
            }

            return new TrainingCreationResult(); 
        }

        public Task<bool> DeleteTrainingAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutNotesApi.DomainModel.Entities;

namespace WorkoutNotesApi.Foundation.Trainings
{
    public interface ITrainingTrackingService
    {
        Task<IReadOnlyCollection<Training>> GetTrainingsAsync();

        Task<Training> GetTrainingAsync(Guid id);

        Task<TrainingCreationResult> CreateTrainingAsync(Training trainingCreationResult);

        Task<bool> DeleteTrainingAsync(Guid id);
    }
}
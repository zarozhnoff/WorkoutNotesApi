using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutNotes.DomainModel.Entities;

namespace WorkoutNotes.Foundation.Trainings
{
    public interface ITrainingTrackingService
    {
        Task<IReadOnlyCollection<Training>> GetTrainingsAsync();

        Task<Training> GetTrainingAsync(Guid id);

        Task<TrainingCreationResult> CreateTrainingAsync(Training trainingCreationResult);

        Task<bool> DeleteTrainingAsync(Guid id);
    }
}
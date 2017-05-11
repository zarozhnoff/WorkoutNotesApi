﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutNotesApi.DomainModel.Entities;

namespace WorkoutNotesApi.Foundation.Interfaces
{
    public interface ITrainingTrackingService
    {
        Task<IReadOnlyCollection<Training>> GetTrainingsAsync();

        Task<Training> GetTrainingAsync(Guid id);

        Task CreateTrainingAsync(Training training);
    }
}
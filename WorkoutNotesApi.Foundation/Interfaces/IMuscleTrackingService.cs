using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutNotesApi.DomainModel.Entities;

namespace WorkoutNotesApi.Foundation.Interfaces
{
    public interface IMuscleTrackingService
    {
        Task<IReadOnlyCollection<Muscle>> GetMusclesAsync();
    }
}
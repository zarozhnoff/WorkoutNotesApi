using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutNotesApi.DomainModel.Entities;

namespace WorkoutNotesApi.Foundation.Muscles
{
    public interface IMuscleTrackingService
    {
        Task<IReadOnlyCollection<Muscle>> GetMusclesAsync();
    }
}
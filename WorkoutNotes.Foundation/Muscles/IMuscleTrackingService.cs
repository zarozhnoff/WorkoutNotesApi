using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutNotes.DomainModel.Entities;

namespace WorkoutNotes.Foundation.Muscles
{
    public interface IMuscleTrackingService
    {
        Task<IReadOnlyCollection<Muscle>> GetMusclesAsync();
    }
}
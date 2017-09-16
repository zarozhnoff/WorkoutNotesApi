using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutNotes.DomainModel.Entities;
using WorkoutNotes.Repositories.Interfaces;

namespace WorkoutNotes.Foundation.Muscles
{
    public class MuscleTrackingService : IMuscleTrackingService
    {
        private readonly IApplicationUnitOfWorkFactory _uowFactory;


        public MuscleTrackingService(IApplicationUnitOfWorkFactory uowFactory)
        {
            _uowFactory = uowFactory;
        }


        public async Task<IReadOnlyCollection<Muscle>> GetMusclesAsync()
        {
            using (var uow = _uowFactory.Create())
            {
                var repository = uow.GetRepository<Muscle>();

                return await repository.GetAllAsync();
            }
        }
    }
}
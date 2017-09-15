using System.Collections.Generic;
using System.Threading.Tasks;
using WorkoutNotesApi.DAL.Interfaces;
using WorkoutNotesApi.DomainModel.Entities;

namespace WorkoutNotesApi.Foundation.Muscles
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
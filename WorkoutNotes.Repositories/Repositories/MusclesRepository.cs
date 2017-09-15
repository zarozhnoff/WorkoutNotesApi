using System.Linq;
using WorkoutNotesApi.DAL.Interfaces;
using WorkoutNotesApi.DomainModel.Entities;

namespace WorkoutNotesApi.DAL.Repositories
{
    public class MusclesRepository : Repository<Muscle>
    {
        public MusclesRepository(IApplicationDbContext context) : base(context)
        {
        }


        protected override IQueryable<Muscle> GetAllQuery()
        {
            return GetQuery(m => m.Name.Translations);
        }
    }
}
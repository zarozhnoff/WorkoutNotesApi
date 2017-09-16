using System.Linq;
using WorkoutNotes.DomainModel.Entities;
using WorkoutNotes.Repositories.Interfaces;

namespace WorkoutNotes.Repositories.Repositories
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
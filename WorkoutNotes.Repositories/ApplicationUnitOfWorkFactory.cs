using WorkoutNotesApi.DAL.Interfaces;

namespace WorkoutNotesApi.DAL
{
    public class ApplicationUnitOfWorkFactory : IApplicationUnitOfWorkFactory
    {
        public IApplicationUnitOfWork Create()
        {
            var context = new ApplicationDbContext();
            return new ApplicationUnitOfWork(context);
        }
    }
}
using WorkoutNotes.Repositories.Interfaces;

namespace WorkoutNotes.Repositories
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
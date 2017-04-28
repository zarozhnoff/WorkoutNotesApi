using WorkoutNotesApi.DAL.Interfaces;

namespace WorkoutNotesApi.DAL
{
    public class ApplicationUnitOfWorkFactory : IApplicationUnitOfWorkFactory
    {
        public IApplicationUnitOfWork Create()
        {
            return new ApplicationUnitOfWork();
        }
    }
}
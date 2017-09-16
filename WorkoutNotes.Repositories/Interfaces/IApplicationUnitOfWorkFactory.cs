namespace WorkoutNotes.Repositories.Interfaces
{
    public interface IApplicationUnitOfWorkFactory
    {
        IApplicationUnitOfWork Create();
    }
}
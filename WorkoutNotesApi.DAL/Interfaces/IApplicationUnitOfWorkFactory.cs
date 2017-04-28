namespace WorkoutNotesApi.DAL.Interfaces
{
    public interface IApplicationUnitOfWorkFactory
    {
        IApplicationUnitOfWork Create();
    }
}
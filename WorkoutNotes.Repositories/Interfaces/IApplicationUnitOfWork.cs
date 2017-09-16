using System;
using System.Threading.Tasks;

namespace WorkoutNotes.Repositories.Interfaces
{
    public interface IApplicationUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        Task SaveChangesAsync();
    }
}
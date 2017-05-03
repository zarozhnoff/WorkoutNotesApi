using System;
using System.Threading.Tasks;

namespace WorkoutNotesApi.DAL.Interfaces
{
    public interface IApplicationUnitOfWork : IDisposable
    {
        Task SaveChangesAsync();
    }
}
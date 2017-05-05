using System.Collections.Generic;
using System.Threading.Tasks;

namespace WorkoutNotesApi.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IReadOnlyCollection<T>> GetAllAsync();
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WorkoutNotes.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IReadOnlyCollection<T>> GetAllAsync();

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
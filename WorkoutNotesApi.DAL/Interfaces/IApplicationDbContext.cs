using System.Data.Entity;
using System.Threading.Tasks;

namespace WorkoutNotesApi.DAL.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<T> Set<T>() where T : class;

        Task<int> SaveChangesAsync();
    }
}
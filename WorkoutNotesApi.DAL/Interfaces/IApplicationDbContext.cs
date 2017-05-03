using System.Data.Entity;
using System.Threading.Tasks;
using WorkoutNotesApi.DomainModel.Entities;

namespace WorkoutNotesApi.DAL.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; }

        Task<int> SaveChangesAsync();
    }
}
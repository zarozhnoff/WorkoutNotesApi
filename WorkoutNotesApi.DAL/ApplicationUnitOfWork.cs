using System.Threading.Tasks;
using WorkoutNotesApi.DAL.Interfaces;

namespace WorkoutNotesApi.DAL
{
    public class ApplicationUnitOfWork : IApplicationUnitOfWork
    {
        private readonly IApplicationDbContext _context;


        public ApplicationUnitOfWork(IApplicationDbContext context)
        {
            _context = context;
        }


        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new Repository<TEntity>(_context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
        }
    }
}
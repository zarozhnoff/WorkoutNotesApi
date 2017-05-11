using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using WorkoutNotesApi.DAL.Interfaces;

namespace WorkoutNotesApi.DAL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbset;

        protected readonly IApplicationDbContext Context;


        public Repository(IApplicationDbContext context)
        {
            Context = context;
            _dbset = context.Set<T>();
        }


        public async Task<IReadOnlyCollection<T>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }
    }
}
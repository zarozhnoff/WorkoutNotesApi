using System.Diagnostics;
using System.Linq;
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
            var user = _context.Users.FirstOrDefault();
            Trace.WriteLine(user.FirstName);
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
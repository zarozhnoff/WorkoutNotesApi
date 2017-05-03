using System.Data.Entity;
using WorkoutNotesApi.DAL.Interfaces;
using WorkoutNotesApi.DomainModel.Entities;

namespace WorkoutNotesApi.DAL
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private const string ConnectionString = "WorkoutNotesDb";


        public DbSet<User> Users { get; set; }


        public ApplicationDbContext() : base(ConnectionString)
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
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
            FixEfProviderServicesProblem();
        }


        private static void FixEfProviderServicesProblem()
        {
            // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            // Make sure the provider assembly is available to the running application. 
            // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            // ReSharper disable once UnusedVariable
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
using System.Data.Entity.Migrations;

namespace WorkoutNotes.Repositories.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }


        protected override void Seed(ApplicationDbContext context)
        {

        }
    }
}
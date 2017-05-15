using System.Data.Entity.Migrations;

namespace WorkoutNotesApi.DAL.Migrations
{
    public partial class FixSortOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Muscles", "SortOrder", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Muscles", "SortOrder");
        }
    }
}
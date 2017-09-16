using System.Data.Entity.Migrations;

namespace WorkoutNotes.Repositories.Migrations
{
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FirstName = c.String(),
                    Gender = c.Int(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Trainings",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Date = c.DateTime(nullable: false),
                    Comment = c.String(),
                    CreationDate = c.DateTime(nullable: false),
                    UserId = c.Int(nullable: false),
                    ExternalId = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);

            CreateTable(
                "dbo.Muscles",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    NameId = c.Int(nullable: false),
                    SortOrder = c.Int(nullable: false),
                    ExternalId = c.Guid(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MultiLanguageStrings", t => t.NameId, cascadeDelete: true)
                .Index(t => t.NameId);

            CreateTable(
                "dbo.MultiLanguageStrings",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Translations",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    MultiLanguageStringId = c.Int(nullable: false),
                    Value = c.String(),
                    LanguageName = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MultiLanguageStrings", t => t.MultiLanguageStringId, cascadeDelete: true)
                .Index(t => t.MultiLanguageStringId);

            CreateTable(
                "dbo.MuscleTrainings",
                c => new
                {
                    Muscle_Id = c.Int(nullable: false),
                    Training_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Muscle_Id, t.Training_Id })
                .ForeignKey("dbo.Muscles", t => t.Muscle_Id, cascadeDelete: true)
                .ForeignKey("dbo.Trainings", t => t.Training_Id, cascadeDelete: true)
                .Index(t => t.Muscle_Id)
                .Index(t => t.Training_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Trainings", "UserId", "dbo.Users");
            DropForeignKey("dbo.MuscleTrainings", "Training_Id", "dbo.Trainings");
            DropForeignKey("dbo.MuscleTrainings", "Muscle_Id", "dbo.Muscles");
            DropForeignKey("dbo.Muscles", "NameId", "dbo.MultiLanguageStrings");
            DropForeignKey("dbo.Translations", "MultiLanguageStringId", "dbo.MultiLanguageStrings");
            DropIndex("dbo.MuscleTrainings", new[] { "Training_Id" });
            DropIndex("dbo.MuscleTrainings", new[] { "Muscle_Id" });
            DropIndex("dbo.Translations", new[] { "MultiLanguageStringId" });
            DropIndex("dbo.Muscles", new[] { "NameId" });
            DropIndex("dbo.Trainings", new[] { "UserId" });
            DropTable("dbo.MuscleTrainings");
            DropTable("dbo.Translations");
            DropTable("dbo.MultiLanguageStrings");
            DropTable("dbo.Muscles");
            DropTable("dbo.Trainings");
            DropTable("dbo.Users");
        }
    }
}
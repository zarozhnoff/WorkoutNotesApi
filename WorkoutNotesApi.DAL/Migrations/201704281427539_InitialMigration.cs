namespace WorkoutNotesApi.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialMigration : DbMigration
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
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LocalizedStrings", t => t.NameId, cascadeDelete: true)
                .Index(t => t.NameId);

            CreateTable(
                "dbo.LocalizedStrings",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.TranslationItems",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    LocalizedStringId = c.Int(nullable: false),
                    Value = c.String(),
                    LanguageName = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LocalizedStrings", t => t.LocalizedStringId, cascadeDelete: true)
                .Index(t => t.LocalizedStringId);

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
            DropForeignKey("dbo.Muscles", "NameId", "dbo.LocalizedStrings");
            DropForeignKey("dbo.TranslationItems", "LocalizedStringId", "dbo.LocalizedStrings");
            DropIndex("dbo.MuscleTrainings", new[] { "Training_Id" });
            DropIndex("dbo.MuscleTrainings", new[] { "Muscle_Id" });
            DropIndex("dbo.TranslationItems", new[] { "LocalizedStringId" });
            DropIndex("dbo.Muscles", new[] { "NameId" });
            DropIndex("dbo.Trainings", new[] { "UserId" });
            DropTable("dbo.MuscleTrainings");
            DropTable("dbo.TranslationItems");
            DropTable("dbo.LocalizedStrings");
            DropTable("dbo.Muscles");
            DropTable("dbo.Trainings");
            DropTable("dbo.Users");
        }
    }
}
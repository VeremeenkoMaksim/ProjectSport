namespace SUDS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        KindOfSport_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KindOfSports", t => t.KindOfSport_Id)
                .Index(t => t.KindOfSport_Id);
            
            CreateTable(
                "dbo.CompetitionJudges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JudgeId = c.Int(nullable: false),
                        CompetitionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.JudgeId, cascadeDelete: true)
                .Index(t => t.JudgeId)
                .Index(t => t.CompetitionId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Role = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KindOfSports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameOfSport = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompetitionId = c.Int(nullable: false),
                        Place = c.Int(nullable: false),
                        Category = c.String(),
                        Sportsman_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .ForeignKey("dbo.Sportsmen", t => t.Sportsman_Id)
                .Index(t => t.CompetitionId)
                .Index(t => t.Sportsman_Id);
            
            CreateTable(
                "dbo.Sportsmen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Weight = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CompetitionSponsors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SponsorId = c.Int(nullable: false),
                        CompetitionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.SponsorId, cascadeDelete: true)
                .Index(t => t.SponsorId)
                .Index(t => t.CompetitionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CompetitionSponsors", "SponsorId", "dbo.Users");
            DropForeignKey("dbo.CompetitionSponsors", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.Results", "Sportsman_Id", "dbo.Sportsmen");
            DropForeignKey("dbo.Results", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.Competitions", "KindOfSport_Id", "dbo.KindOfSports");
            DropForeignKey("dbo.CompetitionJudges", "JudgeId", "dbo.Users");
            DropForeignKey("dbo.CompetitionJudges", "CompetitionId", "dbo.Competitions");
            DropIndex("dbo.CompetitionSponsors", new[] { "CompetitionId" });
            DropIndex("dbo.CompetitionSponsors", new[] { "SponsorId" });
            DropIndex("dbo.Results", new[] { "Sportsman_Id" });
            DropIndex("dbo.Results", new[] { "CompetitionId" });
            DropIndex("dbo.CompetitionJudges", new[] { "CompetitionId" });
            DropIndex("dbo.CompetitionJudges", new[] { "JudgeId" });
            DropIndex("dbo.Competitions", new[] { "KindOfSport_Id" });
            DropTable("dbo.CompetitionSponsors");
            DropTable("dbo.Sportsmen");
            DropTable("dbo.Results");
            DropTable("dbo.KindOfSports");
            DropTable("dbo.Users");
            DropTable("dbo.CompetitionJudges");
            DropTable("dbo.Competitions");
            DropTable("dbo.Categories");
        }
    }
}

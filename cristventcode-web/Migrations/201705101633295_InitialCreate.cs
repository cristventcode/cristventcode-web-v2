namespace cristventcode_web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        ProfileId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Location = c.String(),
                        BioText = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.ProfileId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        ProfileId = c.Int(nullable: false),
                        Title = c.String(),
                        ShortDescription = c.String(),
                        FullDescription = c.String(),
                        GithubUrl = c.String(),
                        InternalUrl = c.String(),
                        ToolsUsed = c.String(),
                    })
                .PrimaryKey(t => t.ProjectId)
                .ForeignKey("dbo.Profiles", t => t.ProfileId, cascadeDelete: true)
                .Index(t => t.ProfileId);
            
            CreateTable(
                "dbo.Writings",
                c => new
                    {
                        WritingId = c.Int(nullable: false, identity: true),
                        ProfileId = c.Int(nullable: false),
                        Title = c.String(),
                        PostDate = c.DateTime(nullable: false),
                        LastEdit = c.DateTime(nullable: false),
                        ExternalUrl = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.WritingId)
                .ForeignKey("dbo.Profiles", t => t.ProfileId, cascadeDelete: true)
                .Index(t => t.ProfileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Writings", "ProfileId", "dbo.Profiles");
            DropForeignKey("dbo.Projects", "ProfileId", "dbo.Profiles");
            DropIndex("dbo.Writings", new[] { "ProfileId" });
            DropIndex("dbo.Projects", new[] { "ProfileId" });
            DropTable("dbo.Writings");
            DropTable("dbo.Projects");
            DropTable("dbo.Profiles");
        }
    }
}

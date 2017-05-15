namespace cristventcode_web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSkillTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillId = c.Int(nullable: false, identity: true),
                        ProfileId = c.Int(nullable: false),
                        Name = c.String(),
                        Level = c.String(),
                        RelevantWorkUrl = c.String(),
                        Active = c.Boolean(nullable: false),
                        Project_ProjectId = c.Int(),
                    })
                .PrimaryKey(t => t.SkillId)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectId)
                .Index(t => t.Project_ProjectId);
            
            DropColumn("dbo.Projects", "ToolsUsed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "ToolsUsed", c => c.String());
            DropForeignKey("dbo.Skills", "Project_ProjectId", "dbo.Projects");
            DropIndex("dbo.Skills", new[] { "Project_ProjectId" });
            DropTable("dbo.Skills");
        }
    }
}

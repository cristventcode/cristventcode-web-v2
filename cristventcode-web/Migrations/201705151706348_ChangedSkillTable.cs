namespace cristventcode_web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedSkillTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Skills", "Project_ProjectId", "dbo.Projects");
            DropIndex("dbo.Skills", new[] { "Project_ProjectId" });
            RenameColumn(table: "dbo.Skills", name: "Project_ProjectId", newName: "ProjectId");
            AlterColumn("dbo.Skills", "ProjectId", c => c.Int(nullable: false));
            CreateIndex("dbo.Skills", "ProjectId");
            AddForeignKey("dbo.Skills", "ProjectId", "dbo.Projects", "ProjectId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Skills", "ProjectId", "dbo.Projects");
            DropIndex("dbo.Skills", new[] { "ProjectId" });
            AlterColumn("dbo.Skills", "ProjectId", c => c.Int());
            RenameColumn(table: "dbo.Skills", name: "ProjectId", newName: "Project_ProjectId");
            CreateIndex("dbo.Skills", "Project_ProjectId");
            AddForeignKey("dbo.Skills", "Project_ProjectId", "dbo.Projects", "ProjectId");
        }
    }
}

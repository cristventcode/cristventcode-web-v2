namespace cristventcode_web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedWritingClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writings", "Active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writings", "Active");
        }
    }
}

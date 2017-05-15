namespace cristventcode_web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedboolentoprojectclass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "Active");
        }
    }
}

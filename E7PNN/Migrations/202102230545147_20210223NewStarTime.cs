namespace E7PNN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20210223NewStarTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Activity", "StatTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Activity", "EndTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Activity", "EndTime");
            DropColumn("dbo.Activity", "StatTime");
        }
    }
}

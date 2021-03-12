namespace E7PNN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20210203NewCause : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Activity", "Cause", c => c.String(maxLength: 400));
            AddColumn("dbo.Announce", "Cause", c => c.String(maxLength: 400));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Announce", "Cause");
            DropColumn("dbo.Activity", "Cause");
        }
    }
}

namespace E7PNN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20210209NewJoinAcc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JoinAccs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Act_ID = c.Int(nullable: false),
                        Member_ID = c.Int(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        JoinStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.JoinAccs");
        }
    }
}

namespace E7PNN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20210304dieForlistkey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Announce", "Member_ID", "dbo.UserTb");
            DropForeignKey("dbo.Opinion", "Member_ID", "dbo.UserTb");
            DropForeignKey("dbo.Transaction", "Prize_ID", "dbo.Prize");
            DropForeignKey("dbo.Transaction", "Member_ID", "dbo.UserTb");
            DropForeignKey("dbo.Activity", "Member_ID", "dbo.UserTb");
            DropIndex("dbo.Activity", new[] { "Member_ID" });
            DropIndex("dbo.Announce", new[] { "Member_ID" });
            DropIndex("dbo.Opinion", new[] { "Member_ID" });
            DropIndex("dbo.Transaction", new[] { "Member_ID" });
            DropIndex("dbo.Transaction", new[] { "Prize_ID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Transaction", "Prize_ID");
            CreateIndex("dbo.Transaction", "Member_ID");
            CreateIndex("dbo.Opinion", "Member_ID");
            CreateIndex("dbo.Announce", "Member_ID");
            CreateIndex("dbo.Activity", "Member_ID");
            AddForeignKey("dbo.Activity", "Member_ID", "dbo.UserTb", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Transaction", "Member_ID", "dbo.UserTb", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Transaction", "Prize_ID", "dbo.Prize", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Opinion", "Member_ID", "dbo.UserTb", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Announce", "Member_ID", "dbo.UserTb", "ID", cascadeDelete: true);
        }
    }
}

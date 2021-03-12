namespace E7PNN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20210306DitFistkey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserTb", "Iden_ID", "dbo.Iden");
            DropForeignKey("dbo.Exp", "User_ID", "dbo.UserTb");
            DropIndex("dbo.Exp", new[] { "User_ID" });
            DropIndex("dbo.UserTb", new[] { "Iden_ID" });
            AddColumn("dbo.Exp", "UserTb_ID", c => c.Int());
            CreateIndex("dbo.Exp", "UserTb_ID");
            AddForeignKey("dbo.Exp", "UserTb_ID", "dbo.UserTb", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exp", "UserTb_ID", "dbo.UserTb");
            DropIndex("dbo.Exp", new[] { "UserTb_ID" });
            DropColumn("dbo.Exp", "UserTb_ID");
            CreateIndex("dbo.UserTb", "Iden_ID");
            CreateIndex("dbo.Exp", "User_ID");
            AddForeignKey("dbo.Exp", "User_ID", "dbo.UserTb", "ID", cascadeDelete: true);
            AddForeignKey("dbo.UserTb", "Iden_ID", "dbo.Iden", "ID", cascadeDelete: true);
        }
    }
}

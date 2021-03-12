namespace E7PNN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20210202FristModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activity",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ActName = c.String(nullable: false, maxLength: 400),
                        ActTime = c.DateTime(nullable: false),
                        Member_ID = c.Int(nullable: false),
                        ActSite = c.String(nullable: false, maxLength: 400),
                        ActType = c.Int(nullable: false),
                        ActUser = c.String(nullable: false, maxLength: 400),
                        SumPeople = c.String(nullable: false, maxLength: 400),
                        ActText = c.String(nullable: false, maxLength: 400),
                        ActClass = c.Int(nullable: false),
                        ActStatus = c.Int(nullable: false),
                        ActLong = c.String(nullable: false, maxLength: 400),
                        ActLat = c.String(nullable: false, maxLength: 400),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserTb", t => t.Member_ID, cascadeDelete: true)
                .Index(t => t.Member_ID);
            
            CreateTable(
                "dbo.UserTb",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserNember = c.String(maxLength: 300),
                        MiNember = c.String(nullable: false, maxLength: 300),
                        Iden_ID = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 300),
                        Points = c.Int(),
                        Name = c.String(maxLength: 300),
                        Phone = c.String(maxLength: 300),
                        UserText = c.String(maxLength: 300),
                        Sex = c.Int(),
                        Niname = c.String(maxLength: 300),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Iden", t => t.Iden_ID, cascadeDelete: true)
                .Index(t => t.Iden_ID);
            
            CreateTable(
                "dbo.Announce",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AnnTime = c.DateTime(nullable: false),
                        AnnSite = c.String(nullable: false, maxLength: 400),
                        AnnType = c.Int(nullable: false),
                        AnnUser = c.String(nullable: false, maxLength: 400),
                        AnnText = c.String(nullable: false, maxLength: 400),
                        Member_ID = c.Int(nullable: false),
                        Pic1 = c.String(nullable: false, maxLength: 400),
                        Pic2 = c.String(nullable: false, maxLength: 400),
                        Pic3 = c.String(nullable: false, maxLength: 400),
                        Pic4 = c.String(nullable: false, maxLength: 400),
                        Pic5 = c.String(nullable: false, maxLength: 400),
                        Status = c.Int(nullable: false),
                        AnnLong = c.String(nullable: false, maxLength: 400),
                        AnnLat = c.String(nullable: false, maxLength: 400),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserTb", t => t.Member_ID, cascadeDelete: true)
                .Index(t => t.Member_ID);
            
            CreateTable(
                "dbo.Exp",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SumExp = c.String(nullable: false, maxLength: 400),
                        Leveles = c.String(nullable: false, maxLength: 400),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserTb", t => t.User_ID, cascadeDelete: true)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Iden",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IdenName = c.String(maxLength: 400),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Opinion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Member_ID = c.Int(nullable: false),
                        OpiType = c.Int(nullable: false),
                        FileName = c.String(maxLength: 400),
                        OpiText = c.String(maxLength: 400),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserTb", t => t.Member_ID, cascadeDelete: true)
                .Index(t => t.Member_ID);
            
            CreateTable(
                "dbo.Transaction",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Member_ID = c.Int(nullable: false),
                        Prize_ID = c.Int(nullable: false),
                        BuyTime = c.DateTime(nullable: false),
                        Amount = c.Int(nullable: false),
                        ExchangeTime = c.DateTime(nullable: false),
                        EndchangeTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Prize", t => t.Prize_ID, cascadeDelete: true)
                .ForeignKey("dbo.UserTb", t => t.Member_ID, cascadeDelete: true)
                .Index(t => t.Member_ID)
                .Index(t => t.Prize_ID);
            
            CreateTable(
                "dbo.Prize",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PrizeName = c.String(nullable: false, maxLength: 300),
                        Stock = c.Int(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo. Like",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Act_ID = c.Int(nullable: false),
                        Member_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserFoot",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Member_ID = c.Int(nullable: false),
                        Act_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activity", "Member_ID", "dbo.UserTb");
            DropForeignKey("dbo.Transaction", "Member_ID", "dbo.UserTb");
            DropForeignKey("dbo.Transaction", "Prize_ID", "dbo.Prize");
            DropForeignKey("dbo.Opinion", "Member_ID", "dbo.UserTb");
            DropForeignKey("dbo.UserTb", "Iden_ID", "dbo.Iden");
            DropForeignKey("dbo.Exp", "User_ID", "dbo.UserTb");
            DropForeignKey("dbo.Announce", "Member_ID", "dbo.UserTb");
            DropIndex("dbo.Transaction", new[] { "Prize_ID" });
            DropIndex("dbo.Transaction", new[] { "Member_ID" });
            DropIndex("dbo.Opinion", new[] { "Member_ID" });
            DropIndex("dbo.Exp", new[] { "User_ID" });
            DropIndex("dbo.Announce", new[] { "Member_ID" });
            DropIndex("dbo.UserTb", new[] { "Iden_ID" });
            DropIndex("dbo.Activity", new[] { "Member_ID" });
            DropTable("dbo.UserFoot");
            DropTable("dbo. Like");
            DropTable("dbo.Prize");
            DropTable("dbo.Transaction");
            DropTable("dbo.Opinion");
            DropTable("dbo.Iden");
            DropTable("dbo.Exp");
            DropTable("dbo.Announce");
            DropTable("dbo.UserTb");
            DropTable("dbo.Activity");
        }
    }
}

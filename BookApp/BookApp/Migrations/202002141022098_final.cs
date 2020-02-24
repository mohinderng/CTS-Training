namespace BookApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        aid = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        adress = c.String(),
                    })
                .PrimaryKey(t => t.aid);
            
            CreateTable(
                "dbo.Detail",
                c => new
                    {
                        sno = c.Int(nullable: false, identity: true),
                        bid = c.Int(nullable: false),
                        aid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.sno)
                .ForeignKey("dbo.Author", t => t.aid, cascadeDelete: true)
                .ForeignKey("dbo.Book", t => t.bid, cascadeDelete: true)
                .Index(t => t.bid)
                .Index(t => t.aid);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        bid = c.Int(nullable: false, identity: true),
                        tytle = c.String(),
                        price = c.String(),
                    })
                .PrimaryKey(t => t.bid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Detail", "bid", "dbo.Book");
            DropForeignKey("dbo.Detail", "aid", "dbo.Author");
            DropIndex("dbo.Detail", new[] { "aid" });
            DropIndex("dbo.Detail", new[] { "bid" });
            DropTable("dbo.Book");
            DropTable("dbo.Detail");
            DropTable("dbo.Author");
        }
    }
}

namespace TaskEntiy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Procus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Cid = c.Int(nullable: false, identity: true),
                        Cname = c.String(),
                        Contact = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Cid);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Pid = c.Int(nullable: false, identity: true),
                        Pname = c.String(),
                        Price = c.Double(nullable: false),
                        Qty = c.Int(nullable: false),
                        Customer_Cid = c.Int(),
                    })
                .PrimaryKey(t => t.Pid)
                .ForeignKey("dbo.Customers", t => t.Customer_Cid)
                .Index(t => t.Customer_Cid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Customer_Cid", "dbo.Customers");
            DropIndex("dbo.Products", new[] { "Customer_Cid" });
            DropTable("dbo.Products");
            DropTable("dbo.Customers");
        }
    }
}

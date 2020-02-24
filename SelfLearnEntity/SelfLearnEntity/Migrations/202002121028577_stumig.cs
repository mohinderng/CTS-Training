namespace SelfLearnEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stumig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Sid = c.Int(nullable: false, identity: true),
                        Sname = c.String(),
                        contact = c.String(),
                    })
                .PrimaryKey(t => t.Sid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}

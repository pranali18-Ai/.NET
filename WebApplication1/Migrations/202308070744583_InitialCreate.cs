namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KEntryConnectUserTable",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        UserType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KEntryConnectUserTable");
        }
    }
}

namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        SecondName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        MotherTown = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("public.Users");
        }
    }
}

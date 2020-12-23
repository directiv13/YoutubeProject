namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "public.UserInfoes",
                c => new
                    {
                        UserInfoId = c.Int(nullable: false, identity: true),
                        UsedId = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        SecondName = c.String(nullable: false),
                        MotherTown = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        user_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.UserInfoId)
                .ForeignKey("public.Users", t => t.user_UserId)
                .Index(t => t.user_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.UserInfoes", "user_UserId", "public.Users");
            DropIndex("public.UserInfoes", new[] { "user_UserId" });
            DropTable("public.UserInfoes");
            DropTable("public.Users");
        }
    }
}

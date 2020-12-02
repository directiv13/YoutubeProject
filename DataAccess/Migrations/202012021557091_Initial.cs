namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.Users", "SecondName", c => c.String(nullable: false));
            AddColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Users", "MotherTown", c => c.String(nullable: false));
            AddColumn("dbo.Users", "BirthDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Username", c => c.String());
            DropColumn("dbo.Users", "BirthDate");
            DropColumn("dbo.Users", "MotherTown");
            DropColumn("dbo.Users", "Email");
            DropColumn("dbo.Users", "SecondName");
            DropColumn("dbo.Users", "FirstName");
        }
    }
}

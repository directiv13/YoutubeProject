namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emailPassword : DbMigration
    {
        public override void Up()
        {
            DropColumn("public.Users", "Username");
        }
        
        public override void Down()
        {
            AddColumn("public.Users", "Username", c => c.String(nullable: false));
        }
    }
}

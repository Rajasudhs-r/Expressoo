namespace Expressoo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MenuTypeAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "Email");
        }
    }
}

namespace InventarioPizzeriaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopsAndUsers2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Shops", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Username", c => c.Int(nullable: false));
            AlterColumn("dbo.Shops", "Name", c => c.Int(nullable: false));
        }
    }
}

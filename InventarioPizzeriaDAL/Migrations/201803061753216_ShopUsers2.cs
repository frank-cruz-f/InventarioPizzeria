namespace InventarioPizzeriaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopUsers2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doughs", "ShopId", c => c.Int(nullable: false));
            CreateIndex("dbo.Doughs", "ShopId");
            AddForeignKey("dbo.Doughs", "ShopId", "dbo.Shops", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doughs", "ShopId", "dbo.Shops");
            DropIndex("dbo.Doughs", new[] { "ShopId" });
            DropColumn("dbo.Doughs", "ShopId");
        }
    }
}

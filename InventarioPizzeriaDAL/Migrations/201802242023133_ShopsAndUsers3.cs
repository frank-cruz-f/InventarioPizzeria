namespace InventarioPizzeriaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopsAndUsers3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doughs", "ShopId", "dbo.Shops");
            DropIndex("dbo.Doughs", new[] { "ShopId" });
            DropColumn("dbo.Doughs", "ShopId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doughs", "ShopId", c => c.Int(nullable: false));
            CreateIndex("dbo.Doughs", "ShopId");
            AddForeignKey("dbo.Doughs", "ShopId", "dbo.Shops", "ID", cascadeDelete: true);
        }
    }
}

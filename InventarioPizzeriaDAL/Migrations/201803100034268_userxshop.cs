namespace InventarioPizzeriaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userxshop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ShopId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "ShopId");
            AddForeignKey("dbo.Users", "ShopId", "dbo.Shops", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "ShopId", "dbo.Shops");
            DropIndex("dbo.Users", new[] { "ShopId" });
            DropColumn("dbo.Users", "ShopId");
        }
    }
}

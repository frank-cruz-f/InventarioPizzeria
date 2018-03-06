namespace InventarioPizzeriaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShopsAndUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.Int(nullable: false),
                        Password = c.Int(nullable: false),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Doughs", "ShopId", c => c.Int(nullable: false));
            CreateIndex("dbo.Doughs", "ShopId");
            AddForeignKey("dbo.Doughs", "ShopId", "dbo.Shops", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doughs", "ShopId", "dbo.Shops");
            DropIndex("dbo.Doughs", new[] { "ShopId" });
            DropColumn("dbo.Doughs", "ShopId");
            DropTable("dbo.Users");
            DropTable("dbo.Shops");
        }
    }
}

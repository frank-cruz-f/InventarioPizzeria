namespace InventarioPizzeriaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CallCenterReport : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "ShopId", c => c.Int(nullable: false));
            AddColumn("dbo.Reports", "IsCallCenterReport", c => c.Boolean(nullable: false));
            AddColumn("dbo.Reports", "InitialDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Reports", "FinalDate", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Reports", "ShopId");
            AddForeignKey("dbo.Reports", "ShopId", "dbo.Shops", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reports", "ShopId", "dbo.Shops");
            DropIndex("dbo.Reports", new[] { "ShopId" });
            DropColumn("dbo.Reports", "FinalDate");
            DropColumn("dbo.Reports", "InitialDate");
            DropColumn("dbo.Reports", "IsCallCenterReport");
            DropColumn("dbo.Reports", "ShopId");
        }
    }
}

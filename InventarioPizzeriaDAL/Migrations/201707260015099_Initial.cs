namespace InventarioPizzeriaDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doughs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Grams = c.Int(nullable: false),
                        CookName = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Operation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Code = c.String(nullable: false, maxLength: 50, unicode: false),
                        DoughGrams = c.Int(nullable: false),
                        CheeseGrams = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SpentDough = c.Int(nullable: false),
                        InitialDough = c.Int(nullable: false),
                        RemainingDough = c.Int(nullable: false),
                        BurntDough = c.Int(nullable: false),
                        SpentCheese = c.Int(nullable: false),
                        Date = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reports");
            DropTable("dbo.Product");
            DropTable("dbo.Doughs");
        }
    }
}

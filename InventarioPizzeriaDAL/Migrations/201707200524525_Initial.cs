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
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Code = c.String(nullable: false, maxLength: 50, unicode: false),
                        DoughGrams = c.Int(nullable: false),
                        CheeseGrams = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Product");
            DropTable("dbo.Doughs");
        }
    }
}

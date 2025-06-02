namespace Cursov_Proekt4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Proekt4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DishesName = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Weight = c.Double(nullable: false),
                        DishType_Id = c.Int(),
                        DishName_Id = c.Int(),
                        DishType_Id1 = c.Int(),
                        DishTypeId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DishTypes", t => t.DishType_Id)
                .ForeignKey("dbo.DishTypes", t => t.DishName_Id)
                .ForeignKey("dbo.DishTypes", t => t.DishType_Id1)
                .ForeignKey("dbo.DishTypes", t => t.DishTypeId_Id)
                .Index(t => t.DishType_Id)
                .Index(t => t.DishName_Id)
                .Index(t => t.DishType_Id1)
                .Index(t => t.DishTypeId_Id);
            
            CreateTable(
                "dbo.DishTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DishTypeId = c.Int(nullable: false),
                        DishName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dishes", "DishTypeId_Id", "dbo.DishTypes");
            DropForeignKey("dbo.Dishes", "DishType_Id1", "dbo.DishTypes");
            DropForeignKey("dbo.Dishes", "DishName_Id", "dbo.DishTypes");
            DropForeignKey("dbo.Dishes", "DishType_Id", "dbo.DishTypes");
            DropIndex("dbo.Dishes", new[] { "DishTypeId_Id" });
            DropIndex("dbo.Dishes", new[] { "DishType_Id1" });
            DropIndex("dbo.Dishes", new[] { "DishName_Id" });
            DropIndex("dbo.Dishes", new[] { "DishType_Id" });
            DropTable("dbo.DishTypes");
            DropTable("dbo.Dishes");
        }
    }
}

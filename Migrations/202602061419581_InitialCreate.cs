namespace AdanaCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cafes",
                c => new
                    {
                        CafeId = c.Int(nullable: false, identity: true),
                        CafeName = c.String(),
                        District = c.String(),
                        Address = c.String(),
                        IsStudent = c.Boolean(nullable: false),
                        IsForFamily = c.Boolean(nullable: false),
                        IsForWorking = c.Boolean(nullable: false),
                        IsForFun = c.Boolean(nullable: false),
                        PhotoUrl = c.String(),
                    })
                .PrimaryKey(t => t.CafeId);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        MenuId = c.Int(nullable: false, identity: true),
                        CafeId = c.Int(nullable: false),
                        Category = c.String(),
                        ItemNam = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MenuId)
                .ForeignKey("dbo.Cafes", t => t.CafeId, cascadeDelete: true)
                .Index(t => t.CafeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Menus", "CafeId", "dbo.Cafes");
            DropIndex("dbo.Menus", new[] { "CafeId" });
            DropTable("dbo.Menus");
            DropTable("dbo.Cafes");
        }
    }
}

namespace TDP_CRUD2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryID = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Categories_CategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Category", t => t.Categories_CategoryID)
                .Index(t => t.Categories_CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Categories_CategoryID", "dbo.Category");
            DropIndex("dbo.Product", new[] { "Categories_CategoryID" });
            DropTable("dbo.Product");
            DropTable("dbo.Category");
        }
    }
}

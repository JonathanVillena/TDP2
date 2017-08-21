namespace TDP_CRUD2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fristmigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Product", "Categories_CategoryID", "dbo.Category");
            DropIndex("dbo.Product", new[] { "Categories_CategoryID" });
            RenameColumn(table: "dbo.Product", name: "Categories_CategoryID", newName: "categoryID");
            AlterColumn("dbo.Product", "categoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Product", "categoryID");
            AddForeignKey("dbo.Product", "categoryID", "dbo.Category", "CategoryID", cascadeDelete: true);
            DropColumn("dbo.Category", "ProductID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Category", "ProductID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Product", "categoryID", "dbo.Category");
            DropIndex("dbo.Product", new[] { "categoryID" });
            AlterColumn("dbo.Product", "categoryID", c => c.Int());
            RenameColumn(table: "dbo.Product", name: "categoryID", newName: "Categories_CategoryID");
            CreateIndex("dbo.Product", "Categories_CategoryID");
            AddForeignKey("dbo.Product", "Categories_CategoryID", "dbo.Category", "CategoryID");
        }
    }
}

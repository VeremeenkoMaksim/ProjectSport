namespace SUDS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit_Category : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KindOfSports", "Category_Id", c => c.Int());
            CreateIndex("dbo.KindOfSports", "Category_Id");
            AddForeignKey("dbo.KindOfSports", "Category_Id", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KindOfSports", "Category_Id", "dbo.Categories");
            DropIndex("dbo.KindOfSports", new[] { "Category_Id" });
            DropColumn("dbo.KindOfSports", "Category_Id");
        }
    }
}

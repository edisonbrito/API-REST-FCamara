namespace FCamara.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InclusaoDeProduto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Product", "Category_Id", "dbo.Category");
            DropIndex("dbo.Product", new[] { "Category_Id" });
            DropColumn("dbo.Product", "Category_Id");
            DropTable("dbo.Category");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Product", "Category_Id", c => c.Int());
            CreateIndex("dbo.Product", "Category_Id");
            AddForeignKey("dbo.Product", "Category_Id", "dbo.Category", "Id");
        }
    }
}

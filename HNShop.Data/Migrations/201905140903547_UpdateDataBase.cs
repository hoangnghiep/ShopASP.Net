namespace HNShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDataBase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategories", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "HomeFlag", c => c.Boolean());
            AddColumn("dbo.Posts", "MetaDescription", c => c.String(maxLength: 256));
            DropColumn("dbo.Products", "MetaDesription");
            DropColumn("dbo.ProductCategories", "MetaDesription");
            DropColumn("dbo.Pages", "MetaDesription");
            DropColumn("dbo.PostCategories", "MetaDesription");
            DropColumn("dbo.Posts", "HomFlag");
            DropColumn("dbo.Posts", "MetaDesription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "MetaDesription", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "HomFlag", c => c.Boolean());
            AddColumn("dbo.PostCategories", "MetaDesription", c => c.String(maxLength: 256));
            AddColumn("dbo.Pages", "MetaDesription", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategories", "MetaDesription", c => c.String(maxLength: 256));
            AddColumn("dbo.Products", "MetaDesription", c => c.String(maxLength: 256));
            DropColumn("dbo.Posts", "MetaDescription");
            DropColumn("dbo.Posts", "HomeFlag");
            DropColumn("dbo.PostCategories", "MetaDescription");
            DropColumn("dbo.Pages", "MetaDescription");
            DropColumn("dbo.ProductCategories", "MetaDescription");
            DropColumn("dbo.Products", "MetaDescription");
        }
    }
}

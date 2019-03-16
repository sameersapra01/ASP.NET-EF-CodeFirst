namespace ASP.NET_EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerOrderModels2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderType", c => c.String(nullable: false, maxLength: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "OrderType");
        }
    }
}

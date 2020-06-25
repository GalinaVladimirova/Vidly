namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNumberInStockPropertyOfMovieToByte : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "NubmerInStock", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "NubmerInStock", c => c.Int(nullable: false));
        }
    }
}

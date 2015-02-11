namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoubleToDecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Films", "ReleaseDate", c => c.Int(nullable: false));
            AlterColumn("dbo.Films", "ImdbRating", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Films", "MyRating", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Films", "MyRating", c => c.Double());
            AlterColumn("dbo.Films", "ImdbRating", c => c.Double(nullable: false));
            AlterColumn("dbo.Films", "ReleaseDate", c => c.Double(nullable: false));
        }
    }
}

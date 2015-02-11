namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntToDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Films", "ImdbRating", c => c.Double(nullable: false));
            AlterColumn("dbo.Films", "MyRating", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Films", "MyRating", c => c.Int());
            AlterColumn("dbo.Films", "ImdbRating", c => c.Int(nullable: false));
        }
    }
}

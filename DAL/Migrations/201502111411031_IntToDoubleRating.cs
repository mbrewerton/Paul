namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntToDoubleRating : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Films", "ReleaseDate", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Films", "ReleaseDate", c => c.Int(nullable: false));
        }
    }
}

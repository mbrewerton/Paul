namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedMaxLengthFromSynopsis : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Films", "Synopsis", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Films", "Synopsis", c => c.String(nullable: false, maxLength: 100));
        }
    }
}

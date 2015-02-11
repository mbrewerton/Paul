namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedWatchedField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "Watched", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Watched");
        }
    }
}

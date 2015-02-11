namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Film : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FilmName = c.String(nullable: false),
                        ReleaseDate = c.Int(nullable: false),
                        Genre = c.String(nullable: false),
                        Synopsis = c.String(nullable: false, maxLength: 100),
                        ImdbRating = c.Int(nullable: false),
                        MyRating = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Films");
        }
    }
}

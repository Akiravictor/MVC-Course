namespace AkiraMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelChanges1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GenreModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.MovieModels", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.MovieModels", "GenreId");
            AddForeignKey("dbo.MovieModels", "GenreId", "dbo.GenreModels", "Id", cascadeDelete: true);
            DropColumn("dbo.MovieModels", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MovieModels", "Genre", c => c.String());
            DropForeignKey("dbo.MovieModels", "GenreId", "dbo.GenreModels");
            DropIndex("dbo.MovieModels", new[] { "GenreId" });
            DropColumn("dbo.MovieModels", "GenreId");
            DropTable("dbo.GenreModels");
        }
    }
}

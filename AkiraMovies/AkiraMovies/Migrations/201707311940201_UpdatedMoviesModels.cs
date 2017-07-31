namespace AkiraMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedMoviesModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovieModels", "Genre", c => c.String());
            AddColumn("dbo.MovieModels", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MovieModels", "AddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MovieModels", "NumberInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MovieModels", "NumberInStock");
            DropColumn("dbo.MovieModels", "AddedDate");
            DropColumn("dbo.MovieModels", "ReleaseDate");
            DropColumn("dbo.MovieModels", "Genre");
        }
    }
}

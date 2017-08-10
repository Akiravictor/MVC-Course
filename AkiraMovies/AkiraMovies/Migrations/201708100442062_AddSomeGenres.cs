namespace AkiraMovies.Migrations
{
	using System;
	using System.Data.Entity.Migrations;
	
	public partial class AddSomeGenres : DbMigration
	{
		public override void Up()
		{
			Sql("INSERT INTO GenreModels ( Name) VALUES ( 'Action')");
			Sql("INSERT INTO GenreModels ( Name) VALUES ( 'Drama')");
			Sql("INSERT INTO GenreModels ( Name) VALUES ( 'Family')");
			Sql("INSERT INTO GenreModels ( Name) VALUES ( 'Romance')");
			Sql("INSERT INTO GenreModels ( Name) VALUES ( 'Comedy')");
			
		}
		
		public override void Down()
		{
		}
	}
}

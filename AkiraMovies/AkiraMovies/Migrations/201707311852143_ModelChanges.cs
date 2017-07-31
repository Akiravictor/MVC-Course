namespace AkiraMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerModels", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.MovieModels", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MovieModels", "Name", c => c.String());
            AlterColumn("dbo.CustomerModels", "Name", c => c.String());
        }
    }
}

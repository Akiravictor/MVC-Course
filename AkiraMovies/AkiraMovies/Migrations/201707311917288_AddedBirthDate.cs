namespace AkiraMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBirthDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerModels", "BirthDate", c => c.DateTime());

            Sql(@"Update CustomerModels set BirthDate = '1991-12-04' where Id = 1");
            Sql(@"Update CustomerModels set BirthDate = '2003-08-23' where Id = 3");

        }

        public override void Down()
        {
            DropColumn("dbo.CustomerModels", "BirthDate");
        }
    }
}

namespace AkiraMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBirthDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerModels", "Birthdate", c => c.DateTime());

            Sql(@"Update CustomerModels set Birthdate = '1991-12-04' where Id = 1");
            Sql(@"Update CustomerModels set Birthdate = '2003-08-23' where Id = 3");

        }

        public override void Down()
        {
            DropColumn("dbo.CustomerModels", "Birthdate");
        }
    }
}

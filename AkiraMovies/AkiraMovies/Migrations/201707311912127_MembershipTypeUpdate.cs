namespace AkiraMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTypeUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypeModels", "Name", c => c.String());

            Sql(@"Update MembershipTypeModels set Name = 'Pay as you go' where Id = 1");
            Sql(@"Update MembershipTypeModels set Name = 'Monthly' where Id = 2");
            Sql(@"Update MembershipTypeModels set Name = 'Quarterly' where Id = 3");
            Sql(@"Update MembershipTypeModels set Name = 'Anually' where Id = 4");

        }

        public override void Down()
        {
            DropColumn("dbo.MembershipTypeModels", "Name");
        }
    }
}

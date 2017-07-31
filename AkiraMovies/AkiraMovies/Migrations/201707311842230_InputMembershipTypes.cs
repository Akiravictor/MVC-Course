namespace AkiraMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InputMembershipTypes : DbMigration
    {
        public override void Up()
        {
            string sql = @"
                    INSERT INTO MembershipTypeModels (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)
                    INSERT INTO MembershipTypeModels (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 30, 1, 10)
                    INSERT INTO MembershipTypeModels (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 90, 3, 15)
                    INSERT INTO MembershipTypeModels (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 300, 12, 20)";

            Sql(sql);
        }
        
        public override void Down()
        {
            string sql = @"DELETE FROM MembershipTypeModels";

            Sql(sql);
        }
    }
}

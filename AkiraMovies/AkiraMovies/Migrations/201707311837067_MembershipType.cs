namespace AkiraMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypeModels",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.CustomerModels", "IsSubscribed", c => c.Boolean(nullable: false));
            AddColumn("dbo.CustomerModels", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.CustomerModels", "MembershipTypeId");
            AddForeignKey("dbo.CustomerModels", "MembershipTypeId", "dbo.MembershipTypeModels", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerModels", "MembershipTypeId", "dbo.MembershipTypeModels");
            DropIndex("dbo.CustomerModels", new[] { "MembershipTypeId" });
            DropColumn("dbo.CustomerModels", "MembershipTypeId");
            DropColumn("dbo.CustomerModels", "IsSubscribed");
            DropTable("dbo.MembershipTypeModels");
        }
    }
}

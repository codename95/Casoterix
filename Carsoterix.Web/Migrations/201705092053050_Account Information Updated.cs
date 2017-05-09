namespace Carsoterix.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountInformationUpdated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "CarOwnerId", "dbo.CarOwners");
            DropIndex("dbo.Cars", new[] { "CarOwnerId" });
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountId = c.String(nullable: false, maxLength: 128),
                        Notes = c.String(),
                        PercentageInterest = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.AccountId);
            
            AddColumn("dbo.Cars", "AccountId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Cars", "AccountId");
            AddForeignKey("dbo.Cars", "AccountId", "dbo.Accounts", "AccountId");
            DropColumn("dbo.Cars", "CarOwnerId");
            DropTable("dbo.CarOwners");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CarOwners",
                c => new
                    {
                        CarOwnerId = c.Byte(nullable: false),
                        OwnerName = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        PercentageInterest = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.CarOwnerId);
            
            AddColumn("dbo.Cars", "CarOwnerId", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Cars", "AccountId", "dbo.Accounts");
            DropIndex("dbo.Cars", new[] { "AccountId" });
            DropColumn("dbo.Cars", "AccountId");
            DropTable("dbo.Accounts");
            CreateIndex("dbo.Cars", "CarOwnerId");
            AddForeignKey("dbo.Cars", "CarOwnerId", "dbo.CarOwners", "CarOwnerId", cascadeDelete: true);
        }
    }
}

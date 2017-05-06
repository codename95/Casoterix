namespace Carsoterix.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewTables : DbMigration
    {
        public override void Up()
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
            
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        CarTypeId = c.Byte(nullable: false),
                        CarTypeName = c.String(),
                    })
                .PrimaryKey(t => t.CarTypeId);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        ColorId = c.Byte(nullable: false),
                        ColorName = c.String(),
                    })
                .PrimaryKey(t => t.ColorId);
            
            AddColumn("dbo.Cars", "RentingPrice", c => c.Double(nullable: false));
            AddColumn("dbo.Cars", "CarTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Cars", "Year", c => c.String());
            AddColumn("dbo.Cars", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Cars", "ImagePath", c => c.String());
            AddColumn("dbo.Cars", "Description", c => c.String());
            AddColumn("dbo.Cars", "CarOwnerId", c => c.Byte(nullable: false));
            AddColumn("dbo.Cars", "IsAvailable", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "ColorId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Cars", "CarTypeId");
            CreateIndex("dbo.Cars", "CarOwnerId");
            CreateIndex("dbo.Cars", "ColorId");
            AddForeignKey("dbo.Cars", "CarOwnerId", "dbo.CarOwners", "CarOwnerId", cascadeDelete: true);
            AddForeignKey("dbo.Cars", "CarTypeId", "dbo.CarTypes", "CarTypeId", cascadeDelete: true);
            AddForeignKey("dbo.Cars", "ColorId", "dbo.Colors", "ColorId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "ColorId", "dbo.Colors");
            DropForeignKey("dbo.Cars", "CarTypeId", "dbo.CarTypes");
            DropForeignKey("dbo.Cars", "CarOwnerId", "dbo.CarOwners");
            DropIndex("dbo.Cars", new[] { "ColorId" });
            DropIndex("dbo.Cars", new[] { "CarOwnerId" });
            DropIndex("dbo.Cars", new[] { "CarTypeId" });
            DropColumn("dbo.Cars", "ColorId");
            DropColumn("dbo.Cars", "IsAvailable");
            DropColumn("dbo.Cars", "CarOwnerId");
            DropColumn("dbo.Cars", "Description");
            DropColumn("dbo.Cars", "ImagePath");
            DropColumn("dbo.Cars", "DateAdded");
            DropColumn("dbo.Cars", "Year");
            DropColumn("dbo.Cars", "CarTypeId");
            DropColumn("dbo.Cars", "RentingPrice");
            DropTable("dbo.Colors");
            DropTable("dbo.CarTypes");
            DropTable("dbo.CarOwners");
        }
    }
}

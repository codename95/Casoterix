namespace Carsoterix.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddmebershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Membershiptypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignupFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        Discount = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MembershipTypeId");
            AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.Membershiptypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Customers", "StatusId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "StatusId", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.Membershiptypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            DropColumn("dbo.Customers", "MembershipTypeId");
            DropTable("dbo.Membershiptypes");
        }
    }
}

namespace Carsoterix.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDayAndBankInfoToCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        BankId = c.Byte(nullable: false),
                        BankName = c.String(),
                    })
                .PrimaryKey(t => t.BankId);
            
            AddColumn("dbo.Customers", "CreditCardInformation", c => c.String());
            AddColumn("dbo.Customers", "BankId", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime());
            CreateIndex("dbo.Customers", "BankId");
            AddForeignKey("dbo.Customers", "BankId", "dbo.Banks", "BankId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "BankId", "dbo.Banks");
            DropIndex("dbo.Customers", new[] { "BankId" });
            DropColumn("dbo.Customers", "BirthDate");
            DropColumn("dbo.Customers", "BankId");
            DropColumn("dbo.Customers", "CreditCardInformation");
            DropTable("dbo.Banks");
        }
    }
}

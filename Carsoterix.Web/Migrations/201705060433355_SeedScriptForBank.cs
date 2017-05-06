namespace Carsoterix.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedScriptForBank : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Banks (BankId, BankName) VALUES(1, 'Bank of America')");
            Sql("INSERT INTO Banks (BankId, BankName) VALUES(2, 'Guaranty Trust Bank')");
            Sql("INSERT INTO Banks (BankId, BankName) VALUES(3, 'Salem International Bank')");
        }
        
        public override void Down()
        {
        }
    }
}

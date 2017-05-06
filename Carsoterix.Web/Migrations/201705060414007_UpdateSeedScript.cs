namespace Carsoterix.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSeedScript : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Membershiptypes SET MembershipTypeName = 'Pay as You go where' WHERE Id = 1");
            Sql("UPDATE Membershiptypes SET MembershipTypeName = 'Monthly' WHERE Id = 2");
            Sql("UPDATE Membershiptypes SET MembershipTypeName = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE Membershiptypes SET MembershipTypeName = 'Annually' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}

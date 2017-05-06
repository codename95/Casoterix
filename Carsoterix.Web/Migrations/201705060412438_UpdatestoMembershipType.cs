namespace Carsoterix.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatestoMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Membershiptypes", "MembershipTypeName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Membershiptypes", "MembershipTypeName");
        }
    }
}

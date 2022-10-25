namespace BankManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecustomerinformation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerInformations", "Dob", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerInformations", "Dob", c => c.DateTime(nullable: false));
        }
    }
}

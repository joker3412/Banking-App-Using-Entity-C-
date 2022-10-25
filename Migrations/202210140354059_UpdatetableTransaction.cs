namespace BankManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatetableTransaction : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "TransactionDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "TransactionDate", c => c.DateTime(nullable: false));
        }
    }
}

namespace BankManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtableTransactions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SourceAccount = c.Int(nullable: false),
                        DestinationAccount = c.Int(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                        Mode = c.String(nullable: false, maxLength: 20),
                        RemainingBalance = c.Int(nullable: false),
                        FK_AccountNumberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountInformations", t => t.FK_AccountNumberId, cascadeDelete: true)
                .Index(t => t.FK_AccountNumberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "FK_AccountNumberId", "dbo.AccountInformations");
            DropIndex("dbo.Transactions", new[] { "FK_AccountNumberId" });
            DropTable("dbo.Transactions");
        }
    }
}

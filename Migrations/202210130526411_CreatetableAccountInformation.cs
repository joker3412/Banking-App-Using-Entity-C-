namespace BankManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatetableAccountInformation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountNumber = c.Int(nullable: false),
                        AccountType = c.String(nullable: false, maxLength: 20),
                        Balance = c.Int(nullable: false),
                        Fk_CunstomerInformationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CustomerInformations", t => t.Fk_CunstomerInformationId, cascadeDelete: true)
                .Index(t => t.AccountNumber, unique: true)
                .Index(t => t.Fk_CunstomerInformationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountInformations", "Fk_CunstomerInformationId", "dbo.CustomerInformations");
            DropIndex("dbo.AccountInformations", new[] { "Fk_CunstomerInformationId" });
            DropIndex("dbo.AccountInformations", new[] { "AccountNumber" });
            DropTable("dbo.AccountInformations");
        }
    }
}

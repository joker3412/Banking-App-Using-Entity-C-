namespace BankManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LogInDatas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogInDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        
        public override void Down()
        {
            DropTable("dbo.LogInDatas");
        }
    }
}

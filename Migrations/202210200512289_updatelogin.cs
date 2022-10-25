namespace BankManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatelogin : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.LogInDatas", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LogInDatas", "Status", c => c.Int(nullable: false));
        }
    }
}

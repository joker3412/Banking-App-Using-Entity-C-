namespace BankManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustemerInformation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 10),
                        Dob = c.DateTime(nullable: false),
                        Nationality = c.String(nullable: false, maxLength: 20),
                        Address = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 50),
                        Occupation = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerInformations");
        }
    }
}

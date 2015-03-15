namespace MiniStackOverflow.DataDeployed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Email = c.String(),
                        Password = c.String(),
                        Username = c.String(),
                        Name = c.String(),
                        Lastname = c.String(),
                        Confirm = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        OwnerUsername = c.Guid(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        Votes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Questions");
            DropTable("dbo.Accounts");
        }
    }
}

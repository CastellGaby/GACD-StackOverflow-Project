namespace MiniStackOverflow.DataDeployed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        E_mail = c.String(),
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
                        CreationDate = c.DateTime(nullable: false),
                        Votes = c.Int(nullable: false),
                        OwnerUsername_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.OwnerUsername_Id)
                .Index(t => t.OwnerUsername_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "OwnerUsername_Id", "dbo.Accounts");
            DropIndex("dbo.Questions", new[] { "OwnerUsername_Id" });
            DropTable("dbo.Questions");
            DropTable("dbo.Accounts");
        }
    }
}

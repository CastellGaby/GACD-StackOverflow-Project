namespace MiniStackOverflow.DataDeployed.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Quest : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Questions", "OwnerUsername_Id", "dbo.Accounts");
            DropIndex("dbo.Questions", new[] { "OwnerUsername_Id" });
            AddColumn("dbo.Questions", "OwnerUsername", c => c.Guid(nullable: false));
            DropColumn("dbo.Questions", "OwnerUsername_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "OwnerUsername_Id", c => c.Guid());
            DropColumn("dbo.Questions", "OwnerUsername");
            CreateIndex("dbo.Questions", "OwnerUsername_Id");
            AddForeignKey("dbo.Questions", "OwnerUsername_Id", "dbo.Accounts", "Id");
        }
    }
}

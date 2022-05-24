namespace CodeFirstNewDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeUserToCustomerTableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "Customer");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Customer", newName: "Users");
        }
    }
}

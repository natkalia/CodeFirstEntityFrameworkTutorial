namespace CodeFirstNewDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManualMigrationForTableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "Clients");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Clients", newName: "Customers");
        }
    }
}

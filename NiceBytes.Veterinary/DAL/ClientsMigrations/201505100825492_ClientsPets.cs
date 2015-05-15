namespace NiceBytes.Veterinary.DAL.ClientsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientsPets : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClientsModels", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.ClientsModels", "LastName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClientsModels", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.ClientsModels", "FirstName", c => c.String(maxLength: 50));
        }
    }
}

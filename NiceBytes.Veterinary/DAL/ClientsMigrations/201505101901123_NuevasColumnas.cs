namespace NiceBytes.Veterinary.DAL.ClientsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevasColumnas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientsModels", "DateEntry", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClientsModels", "DateEntry");
        }
    }
}

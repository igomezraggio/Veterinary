namespace NiceBytes.Veterinary.DAL.ClientsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OtroAjuste : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClientsModels", "FirstName", c => c.String());
            AlterColumn("dbo.ClientsModels", "LastName", c => c.String());
            AlterColumn("dbo.ClientsModels", "Email", c => c.String());
            //AlterColumn("dbo.ClientsModels", "DateEntry", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PetsModels", "FirstName", c => c.String());
            //AlterColumn("dbo.PetsModels", "Gender", c => c.String());
            //AlterColumn("dbo.PetsModels", "DateBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PetsModels", "Breed", c => c.String());
            AlterColumn("dbo.PetsModels", "Colour", c => c.String());
            //AlterColumn("dbo.PetsModels", "DateEntry", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PetsModels", "DateEntry", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.PetsModels", "Colour", c => c.String(maxLength: 30));
            AlterColumn("dbo.PetsModels", "Breed", c => c.String(maxLength: 40));
            AlterColumn("dbo.PetsModels", "DateBirth", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.PetsModels", "Gender", c => c.String(nullable: false, maxLength: 1));
            AlterColumn("dbo.PetsModels", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.ClientsModels", "DateEntry", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.ClientsModels", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.ClientsModels", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.ClientsModels", "FirstName", c => c.String(nullable: false, maxLength: 50));
        }
    }
}

namespace NiceBytes.Veterinary.DAL.PetsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevasColumnas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PetsModels", "Gender", c => c.String(nullable: false, maxLength: 1));
            AddColumn("dbo.PetsModels", "DateBirth", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.PetsModels", "Breed", c => c.String(maxLength: 40));
            AddColumn("dbo.PetsModels", "Colour", c => c.String(maxLength: 30));
            AddColumn("dbo.PetsModels", "DateEntry", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PetsModels", "DateEntry");
            DropColumn("dbo.PetsModels", "Colour");
            DropColumn("dbo.PetsModels", "Breed");
            DropColumn("dbo.PetsModels", "DateBirth");
            DropColumn("dbo.PetsModels", "Gender");
        }
    }
}

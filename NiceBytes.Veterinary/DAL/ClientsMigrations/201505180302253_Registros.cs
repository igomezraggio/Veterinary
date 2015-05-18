namespace NiceBytes.Veterinary.DAL.ClientsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Registros : DbMigration
    {
        public override void Up()
        {
            /*
            CreateTable(
                "dbo.Registries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PetsModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PetsModels", t => t.PetsModelId, cascadeDelete: true)
                .Index(t => t.PetsModelId);*/
            
            DropColumn("dbo.PetsModels", "PetNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PetsModels", "PetNumber", c => c.Int(nullable: false));
            DropForeignKey("dbo.Registries", "PetsModelId", "dbo.PetsModels");
            DropIndex("dbo.Registries", new[] { "PetsModelId" });
            DropTable("dbo.Registries");
        }
    }
}

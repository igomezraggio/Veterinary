namespace NiceBytes.Veterinary.DAL.PetsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientsPets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PetsModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PetNumber = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        ClientsModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClientsModels", t => t.ClientsModelId, cascadeDelete: true)
                .Index(t => t.ClientsModelId);
           
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PetsModels", "ClientsModelId", "dbo.ClientsModels");
            DropIndex("dbo.PetsModels", new[] { "ClientsModelId" });
            DropTable("dbo.ClientsModels");
            DropTable("dbo.PetsModels");
        }
    }
}

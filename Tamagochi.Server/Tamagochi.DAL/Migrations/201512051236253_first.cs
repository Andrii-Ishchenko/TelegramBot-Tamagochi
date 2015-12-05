namespace Tamagochi.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PetId = c.Int(nullable: false),
                        Command = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pets", t => t.PetId, cascadeDelete: true)
                .Index(t => t.PetId);
            
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Name = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activities", "PetId", "dbo.Pets");
            DropIndex("dbo.Activities", new[] { "PetId" });
            DropTable("dbo.Pets");
            DropTable("dbo.Activities");
        }
    }
}

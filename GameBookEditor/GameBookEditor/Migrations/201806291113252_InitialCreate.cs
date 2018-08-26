namespace GameBookEditor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GBStoryBlockChoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        text = c.String(),
                        destination_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GBStoryBlocks", t => t.destination_Id)
                .Index(t => t.destination_Id);
            
            CreateTable(
                "dbo.GBStoryBlocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GBStoryBlockChoices", "destination_Id", "dbo.GBStoryBlocks");
            DropIndex("dbo.GBStoryBlockChoices", new[] { "destination_Id" });
            DropTable("dbo.GBStoryBlocks");
            DropTable("dbo.GBStoryBlockChoices");
        }
    }
}

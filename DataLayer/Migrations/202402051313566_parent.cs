namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class parent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        ParntId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ParntId);
            
            AddColumn("dbo.Users", "ParentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "ParentId");
            AddForeignKey("dbo.Users", "ParentId", "dbo.Parents", "ParntId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "ParentId", "dbo.Parents");
            DropIndex("dbo.Users", new[] { "ParentId" });
            DropColumn("dbo.Users", "ParentId");
            DropTable("dbo.Parents");
        }
    }
}

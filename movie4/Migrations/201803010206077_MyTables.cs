namespace movie4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CheckOuts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MovieID = c.Int(nullable: false),
                        EmailAddress = c.String(),
                        BoughtTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Movies", t => t.MovieID, cascadeDelete: true)
                .Index(t => t.MovieID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MovieStatus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CheckOuts", "MovieID", "dbo.Movies");
            DropIndex("dbo.CheckOuts", new[] { "MovieID" });
            DropTable("dbo.MovieStatus");
            DropTable("dbo.Movies");
            DropTable("dbo.CheckOuts");
        }
    }
}

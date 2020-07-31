namespace DatabaseCreating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FirstNames",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        FirstNameValue = c.String(),
                        IsMale = c.Boolean(nullable: false),
                        Genesis = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SecondNames",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        SecondNameValue = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SecondNames");
            DropTable("dbo.FirstNames");
        }
    }
}

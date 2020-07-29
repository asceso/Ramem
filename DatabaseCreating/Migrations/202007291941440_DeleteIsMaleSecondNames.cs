namespace DatabaseCreating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteIsMaleSecondNames : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SecondNames", "IsMale");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SecondNames", "IsMale", c => c.Boolean(nullable: false));
        }
    }
}

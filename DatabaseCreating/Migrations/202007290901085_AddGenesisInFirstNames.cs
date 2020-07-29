namespace DatabaseCreating.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenesisInFirstNames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FirstNames", "Genesis", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FirstNames", "Genesis");
        }
    }
}

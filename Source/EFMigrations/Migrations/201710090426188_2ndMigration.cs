namespace EFMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2ndMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Email", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Email");
        }
    }
}

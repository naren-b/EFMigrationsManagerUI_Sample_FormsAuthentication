namespace EFMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3rdMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "PrimaryPhone", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "PrimaryPhone");
        }
    }
}

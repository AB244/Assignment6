namespace Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pets", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Pets", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pets", "Quantity", c => c.String());
            AlterColumn("dbo.Pets", "Description", c => c.String());
        }
    }
}

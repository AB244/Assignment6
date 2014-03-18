namespace Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class img : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pets", "ImgPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pets", "ImgPath");
        }
    }
}

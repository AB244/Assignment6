namespace Pet_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Description = c.String(),
                        Date_Recieved = c.DateTime(nullable: false),
                        Quantity = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pets");
        }
    }
}

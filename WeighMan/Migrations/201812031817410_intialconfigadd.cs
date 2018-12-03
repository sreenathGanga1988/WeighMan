namespace WeighMan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialconfigadd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WeighConfigMasters",
                c => new
                    {
                        WeighConfigMasterId = c.Int(nullable: false, identity: true),
                        camera = c.String(),
                        device = c.String(),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.WeighConfigMasterId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WeighConfigMasters");
        }
    }
}

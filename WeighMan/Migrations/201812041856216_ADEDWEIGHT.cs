namespace WeighMan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADEDWEIGHT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WeightDatas",
                c => new
                    {
                        WeightDataId = c.Int(nullable: false, identity: true),
                        EntryDate = c.String(),
                        Picture = c.String(),
                        WeightofLoad = c.String(),
                    })
                .PrimaryKey(t => t.WeightDataId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WeightDatas");
        }
    }
}

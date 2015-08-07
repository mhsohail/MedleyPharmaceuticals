namespace MedleyPharmaceuticals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RawProducts",
                c => new
                    {
                        RawProductId = c.Int(nullable: false, identity: true),
                        ReceivingDate = c.DateTime(nullable: false),
                        GRNNo = c.String(),
                        MaterialName = c.String(),
                        BatchNo = c.String(),
                        ManufacturingDate = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        QuantityReceived = c.Int(nullable: false),
                        NoOfCartons = c.Int(nullable: false),
                        ManufacturerOrSupplier = c.String(),
                        BuiltyOrReferenceNo = c.String(),
                    })
                .PrimaryKey(t => t.RawProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RawProducts");
        }
    }
}

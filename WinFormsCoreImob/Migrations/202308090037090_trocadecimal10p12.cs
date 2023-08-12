namespace WinFormsCoreImob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trocadecimal10p12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClienteImovel", "Valor", c => c.Decimal(nullable: false, precision: 12, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClienteImovel", "Valor", c => c.Decimal(nullable: false, precision: 10, scale: 2));
        }
    }
}

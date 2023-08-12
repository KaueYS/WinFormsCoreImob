namespace WinFormsCoreImob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SqlMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteImovel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Celular = c.String(nullable: false, maxLength: 50),
                        ImovelVendendo = c.String(nullable: false, maxLength: 50),
                        Valor = c.Decimal(nullable: false, precision: 10, scale: 2),
                        ImovelComprando = c.String(nullable: false, maxLength: 50),
                        DataCadastro = c.DateTime(nullable: false),
                        Observacoes = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClienteImovel");
        }
    }
}

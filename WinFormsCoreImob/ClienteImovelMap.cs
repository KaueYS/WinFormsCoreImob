using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCoreImob
{
    public class ClienteImovelMap : EntityTypeConfiguration<ClienteImovel>
    {
        public ClienteImovelMap()
        {
            ToTable("ClienteImovel");
            HasKey(x => x.Id);

            Property(x => x.Nome).IsRequired()
                .HasColumnType("nvarchar").HasMaxLength(50);

            Property(x => x.Email).IsRequired()
                .HasColumnType("nvarchar").HasMaxLength(50);

            Property(x => x.Celular).IsRequired()
                .HasColumnType("nvarchar").HasMaxLength(50);

            Property(x => x.ImovelVendendo).IsRequired()
                .HasColumnType("nvarchar").HasMaxLength(50);

            Property(x => x.Valor).IsRequired()
                .HasColumnType("decimal").HasPrecision(12,2);

            Property(x => x.ImovelComprando).IsRequired()
                .HasColumnType("nvarchar").HasMaxLength(50);


            Property(x => x.DataCadastro).IsRequired()
                .HasColumnType("datetime");

            Property(x => x.Observacoes)
                .HasColumnType("nvarchar").HasMaxLength(300);


        }



    }
}

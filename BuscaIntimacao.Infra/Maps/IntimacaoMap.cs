using BuscaIntimacao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuscaIntimacao.Infra.Maps
{
    public class IntimacaoMap : IEntityTypeConfiguration<Intimacao>
    {
        public void Configure(EntityTypeBuilder<Intimacao> builder)
        {
            builder.ToTable("Intimacao");

            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(d => d.Codigo)
               .HasColumnName("Codigo")
               .HasColumnType("Varchar(8)");

            builder.Property(d => d.Ativa)
               .HasColumnName("Ativa")
               .HasColumnType("bit");

            builder.HasOne(d => d.Cartorio);

            builder.HasOne(d => d.Devedor);
        }
    }
}

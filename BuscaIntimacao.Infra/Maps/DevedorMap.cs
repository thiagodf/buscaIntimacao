using BuscaIntimacao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuscaIntimacao.Infra.Maps
{
    public class DevedorMap : IEntityTypeConfiguration<Devedor>
    {
        public void Configure(EntityTypeBuilder<Devedor> builder)
        {
            builder.ToTable("Devedor");

            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(d => d.Nome)
               .HasColumnName("Nome")
               .HasColumnType("varchar(50)");

            builder.OwnsOne(c => c.Documento, documento =>
            {
                documento.Property(e => e.Tipo)
                    .HasColumnName("Tipo")
                    .HasColumnType("int");

                documento.Property(e => e.Numero)
                    .HasColumnName("Numero")
                    .HasColumnType("varchar(50)");
            });
        }
    }
}

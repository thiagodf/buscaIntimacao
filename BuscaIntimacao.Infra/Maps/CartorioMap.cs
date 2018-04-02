using BuscaIntimacao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuscaIntimacao.Infra.Maps
{
    public class CartorioMap : IEntityTypeConfiguration<Cartorio>
    {
        public void Configure(EntityTypeBuilder<Cartorio> builder)
        {
            builder.ToTable("Cartorio");

            builder.Property(c => c.Id)
                .HasColumnName("Id");

            builder.Property(d => d.Nome)
                   .HasColumnName("Nome")
                   .HasColumnType("varchar(50)");

            builder.OwnsOne(c => c.Endereco, endereco =>
            {
                endereco.Property(e => e.Logradouro)
                    .HasColumnName("Endereco")
                    .HasColumnType("varchar(100)");

                endereco.Property(e => e.Bairro)
                    .HasColumnName("Bairro")
                    .HasColumnType("varchar(50)");

                endereco.Property(e => e.Cep)
                   .HasColumnName("Cep")
                   .HasColumnType("varchar(10)");

                endereco.Property(e => e.Cidade)
                   .HasColumnName("Cidade")
                   .HasColumnType("varchar(50)");

                endereco.Property(e => e.Estado)
                   .HasColumnName("Estado")
                   .HasColumnType("int");

                endereco.Property(e => e.Numero)
                   .HasColumnName("Numero")
                   .HasColumnType("int");
            });
        }
    }
}

using BuscaIntimacao.Domain.Entities;
using BuscaIntimacao.Infra.Classes;
using BuscaIntimacao.Infra.Maps;
using Microsoft.EntityFrameworkCore;

namespace BuscaIntimacao.Infra.Context
{
    public class EntityContext : DbContext
    {
        public DbSet<Cartorio> Cartorio { get; set; }
        public DbSet<Devedor> Devedor { get; set; }
        public DbSet<Intimacao> Intimacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CartorioMap());
            modelBuilder.ApplyConfiguration(new DevedorMap());
            modelBuilder.ApplyConfiguration(new IntimacaoMap());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ReadJsonSettings readJsonSettings = new ReadJsonSettings();
            optionsBuilder.UseSqlServer(readJsonSettings.ConnectionString());
        }
    }
}

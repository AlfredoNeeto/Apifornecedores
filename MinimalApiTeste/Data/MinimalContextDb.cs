using Microsoft.EntityFrameworkCore;
using MinimalApiTeste.Models;

namespace MinimalApiTeste.Data
{
    public class MinimalContextDb : DbContext
    {
        public MinimalContextDb(DbContextOptions<MinimalContextDb> options) : base(options) { }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Fornecedor>()
                .Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("Varchar(200)");

            modelBuilder.Entity<Fornecedor>()
               .Property(p => p.Documento)
               .IsRequired()
               .HasColumnType("Varchar(14)");

            modelBuilder.Entity<Fornecedor>()
                .ToTable("Fornecedores");

            base.OnModelCreating(modelBuilder);

        }
    }
}

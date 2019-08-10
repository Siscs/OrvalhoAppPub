using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrvalhoApp.Domain.Models;

namespace OrvalhoApp.Infra.Data.Mappings
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseSqlServerIdentityColumn<long>();
            builder.Property(p => p.Nome).HasColumnType("varchar(50)").IsRequired();
            
            builder.HasData(
                new Categoria[]
                {
                    new Categoria() { Id=1, Nome = "Escritório" },
                    new Categoria() { Id=2, Nome = "Limpeza" }, 
                    new Categoria() { Id=3, Nome = "Eletrônicos" },
                    new Categoria() { Id=4, Nome = "Elétrica" },
                    new Categoria() { Id=5, Nome = "Químicos" },
                    new Categoria() { Id=6, Nome = "Madeira" },
                    new Categoria() { Id=7, Nome = "Outros" }
                }
            );

        }
    }
}
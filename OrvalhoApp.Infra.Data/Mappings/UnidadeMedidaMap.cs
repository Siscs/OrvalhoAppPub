using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrvalhoApp.Domain.Models;

namespace OrvalhoApp.Infra.Data.Mappings
{
    public class UnidadeMedidaMap : IEntityTypeConfiguration<UnidadeMedida>
    {
        public void Configure(EntityTypeBuilder<UnidadeMedida> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseSqlServerIdentityColumn<long>();
            builder.Property(p => p.Nome).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.Descricao).HasColumnType("varchar(50)").IsRequired();
           
            builder.HasData(
                new UnidadeMedida[] {
                    new UnidadeMedida() { Id=1, Nome = "Unidade", Descricao = "Un" },
                    new UnidadeMedida() { Id=2, Nome = "Metro", Descricao = "Mt" },
                    new UnidadeMedida() { Id=3, Nome = "Pacote", Descricao = "Pct" },
                    new UnidadeMedida() { Id=4, Nome = "Litro", Descricao = "Lt" },
                    new UnidadeMedida() { Id=5, Nome = "Quilograma", Descricao = "Kg" },
                    new UnidadeMedida() { Id=6, Nome = "Polegada", Descricao = "Pol" },
                    new UnidadeMedida() { Id=7, Nome = "Centimetro", Descricao = "Cm" },
                    new UnidadeMedida() { Id=8, Nome = "Milimetro", Descricao = "Mm" },
                    new UnidadeMedida() { Id=9, Nome = "Caixa", Descricao = "Cx" },
                    new UnidadeMedida() { Id=10, Nome = "Lata", Descricao = "Lata" }
                }
            );
        }
    }
}
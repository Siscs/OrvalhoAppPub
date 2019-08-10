using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrvalhoApp.Domain.Models;

namespace OrvalhoApp.Infra.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseSqlServerIdentityColumn<long>();
            builder.Property(p => p.Nome).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.Preco).HasColumnType("decimal(10,2)");
            builder.Property(p => p.Quantidade).HasColumnType("decimal(10,3)");
            builder.Property(p=> p.Bloqueado).HasColumnType("bit").IsRequired();

            // relacionamento one to many            
            builder.HasOne<Categoria>(p => p.Categoria).WithMany().HasForeignKey(fk => fk.CategoriaId);
            builder.HasOne<UnidadeMedida>(p => p.UnidadeMedida).WithMany().HasForeignKey(fk => fk.UnidadeMedidaId);

            builder.HasData(
                new Produto[] { 
                    new Produto() { Id = 1, Nome="Caneta Azul", Preco=2, Quantidade=20, Bloqueado=false, CategoriaId=1, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 2, Nome="Caneta Vermelha", Preco=2, Quantidade=18, Bloqueado=false, CategoriaId=1, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 3, Nome="Caneta Verde", Preco=3, Quantidade=0, Bloqueado=false, CategoriaId=1, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 4, Nome="Caneta Preta", Preco=2, Quantidade=22, Bloqueado=false, CategoriaId=1, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 5, Nome="Borracha", Preco=3, Quantidade=25, Bloqueado=false, CategoriaId=1, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 6, Nome="Lápis", Preco=1, Quantidade=35, Bloqueado=false, CategoriaId=1, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 7, Nome="Papel Sulfite 500fls", Preco=20, Quantidade=5, Bloqueado=false, CategoriaId=1, UnidadeMedidaId=3 }, 
                    new Produto() { Id = 8, Nome="Fio 2mm", Preco=3, Quantidade=120, Bloqueado=false, CategoriaId=4, UnidadeMedidaId=2 }, 
                    new Produto() { Id = 9, Nome="Fio 4mm", Preco=4, Quantidade=140, Bloqueado=false, CategoriaId=4, UnidadeMedidaId=2 }, 
                    new Produto() { Id = 10, Nome="Fio 6mm", Preco=6, Quantidade=120, Bloqueado=false, CategoriaId=4, UnidadeMedidaId=2 }, 
                    new Produto() { Id = 11, Nome="Disjuntor 3 vias", Preco=6, Quantidade=110, Bloqueado=false, CategoriaId=4, UnidadeMedidaId=2 }, 
                    new Produto() { Id = 12, Nome="Bitola J", Preco=14, Quantidade=87, Bloqueado=false, CategoriaId=4, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 13, Nome="Fio 10mm", Preco=35, Quantidade=0, Bloqueado=false, CategoriaId=4, UnidadeMedidaId=2 }, 
                    new Produto() { Id = 14, Nome="Vassoura", Preco=9, Quantidade=5, Bloqueado=false, CategoriaId=2, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 15, Nome="Rodo", Preco=8, Quantidade=6, Bloqueado=false, CategoriaId=2, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 16, Nome="Pano", Preco=4, Quantidade=105, Bloqueado=false, CategoriaId=2, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 17, Nome="Detergente", Preco=2, Quantidade=10, Bloqueado=false, CategoriaId=2, UnidadeMedidaId=4 }, 
                    new Produto() { Id = 18, Nome="Sabão", Preco=3, Quantidade=18, Bloqueado=false, CategoriaId=2, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 19, Nome="Alvejante Veja", Preco=4, Quantidade=10, Bloqueado=false, CategoriaId=2, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 20, Nome="Poliflor", Preco=5, Quantidade=5, Bloqueado=false, CategoriaId=2, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 21, Nome="Radio AM/FM", Preco=120, Quantidade=1, Bloqueado=false, CategoriaId=3, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 22, Nome="TV LED Samsung 46 Pol", Preco=2200, Quantidade=2, Bloqueado=false, CategoriaId=3, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 23, Nome="Celular J7", Preco=1100, Quantidade=3, Bloqueado=false, CategoriaId=3, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 24, Nome="Notebool Dell i7 06gb", Preco=2500, Quantidade=1, Bloqueado=false, CategoriaId=3, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 25, Nome="Forno Microondas", Preco=450, Quantidade=2, Bloqueado=false, CategoriaId=3, UnidadeMedidaId=1 }, 
                    new Produto() { Id = 26, Nome="Teclado Yamaha PSR-950", Preco=5500, Quantidade=1, Bloqueado=false, CategoriaId=3, UnidadeMedidaId=1 }, 

                }
            );
           
        }
    }
}
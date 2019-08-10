using System.Linq;
using System.Collections.Generic;
using OrvalhoApp.Domain.Models;

namespace OrvalhoApp.Infra.Data.Contexto
{
    public class IniciarDB
    {

        public static void Initialize(OrvalhoContext contexto)
        {

            contexto.Database.EnsureCreated();

            if(!contexto.UnidadeMedidas.Any())
            {
                var medidas = new UnidadeMedida[] {
                    new UnidadeMedida() { Nome = "Unidade", Descricao = "Un" },
                    new UnidadeMedida() { Nome = "Metro", Descricao = "Mt" },
                    new UnidadeMedida() { Nome = "Pacote", Descricao = "Pct" },
                    new UnidadeMedida() { Nome = "Litro", Descricao = "Lt" },
                    new UnidadeMedida() { Nome = "Quilograma", Descricao = "Kg" },
                    new UnidadeMedida() { Nome = "Polegada", Descricao = "Pol" },
                    new UnidadeMedida() { Nome = "Centimetro", Descricao = "Cm" },
                    new UnidadeMedida() { Nome = "Milimetro", Descricao = "Mm" },
                    new UnidadeMedida() { Nome = "Caixa", Descricao = "Cx" },
                    new UnidadeMedida() { Nome = "Lata", Descricao = "Lata" }
                };
                contexto.UnidadeMedidas.AddRange(medidas);
            }

            if(!contexto.Categorias.Any()) {

                var categorias = new Categoria[] {
                    new Categoria() { Nome = "Escritório" },
                    new Categoria() { Nome = "Limpeza" },
                    new Categoria() { Nome = "Eletrônicos" },
                    new Categoria() { Nome = "Elétrica" },
                    new Categoria() { Nome = "Químicos" },
                    new Categoria() { Nome = "Madeira" },
                    new Categoria() { Nome = "Outros" }
                };

                contexto.Categorias.AddRange(categorias);
                
            }

            if(!contexto.Produtos.Any()) {

                var produtos = new Produto[] { 
                    new Produto() { Nome="Caneta Azul", Preco=2, Quantidade=20, Bloqueado=false, CategoriaId=1, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Caneta Vermelha", Preco=2, Quantidade=18, Bloqueado=false, CategoriaId=1, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Caneta Verde", Preco=3, Quantidade=0, Bloqueado=false, CategoriaId=1, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Caneta Preta", Preco=2, Quantidade=22, Bloqueado=false, CategoriaId=1, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Borracha", Preco=3, Quantidade=25, Bloqueado=false, CategoriaId=1, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Lápis", Preco=1, Quantidade=35, Bloqueado=false, CategoriaId=1, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Papel Sulfite 500fls", Preco=20, Quantidade=5, Bloqueado=false, CategoriaId=1, UnidadeMedidaId=3 }, 
                    new Produto() { Nome="Fio 2mm", Preco=3, Quantidade=120, Bloqueado=false, CategoriaId=4, UnidadeMedidaId=2 }, 
                    new Produto() { Nome="Fio 4mm", Preco=4, Quantidade=140, Bloqueado=false, CategoriaId=4, UnidadeMedidaId=2 }, 
                    new Produto() { Nome="Fio 6mm", Preco=6, Quantidade=120, Bloqueado=false, CategoriaId=4, UnidadeMedidaId=2 }, 
                    new Produto() { Nome="Disjuntor 3 vias", Preco=6, Quantidade=110, Bloqueado=false, CategoriaId=4, UnidadeMedidaId=2 }, 
                    new Produto() { Nome="Bitola J", Preco=14, Quantidade=87, Bloqueado=false, CategoriaId=4, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Fio 10mm", Preco=35, Quantidade=0, Bloqueado=false, CategoriaId=4, UnidadeMedidaId=2 }, 
                    new Produto() { Nome="Vassoura", Preco=9, Quantidade=5, Bloqueado=false, CategoriaId=2, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Rodo", Preco=8, Quantidade=6, Bloqueado=false, CategoriaId=2, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Pano", Preco=4, Quantidade=105, Bloqueado=false, CategoriaId=2, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Detergente", Preco=2, Quantidade=10, Bloqueado=false, CategoriaId=2, UnidadeMedidaId=4 }, 
                    new Produto() { Nome="Sabão", Preco=3, Quantidade=18, Bloqueado=false, CategoriaId=2, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Alvejante Veja", Preco=4, Quantidade=10, Bloqueado=false, CategoriaId=2, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Poliflor", Preco=5, Quantidade=5, Bloqueado=false, CategoriaId=2, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Radio AM/FM", Preco=120, Quantidade=1, Bloqueado=false, CategoriaId=3, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="TV LED Samsung 46 Pol", Preco=2200, Quantidade=2, Bloqueado=false, CategoriaId=3, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Celular J7", Preco=1100, Quantidade=3, Bloqueado=false, CategoriaId=3, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Notebool Dell i7 06gb", Preco=2500, Quantidade=1, Bloqueado=false, CategoriaId=3, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Forno Microondas", Preco=450, Quantidade=2, Bloqueado=false, CategoriaId=3, UnidadeMedidaId=1 }, 
                    new Produto() { Nome="Teclado Yamaha PSR-950", Preco=5500, Quantidade=1, Bloqueado=false, CategoriaId=3, UnidadeMedidaId=1 }, 

                };

                contexto.Produtos.AddRange(produtos);
                
            }

            contexto.SaveChanges();
            
        }
        
    }
}
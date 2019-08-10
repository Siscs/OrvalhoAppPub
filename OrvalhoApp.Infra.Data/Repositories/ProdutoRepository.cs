using OrvalhoApp.Domain.Models;
using OrvalhoApp.Domain.Interfaces;
using OrvalhoApp.Infra.Data.Contexto;

namespace OrvalhoApp.Infra.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(OrvalhoContext contexto)
            : base(contexto)
        {
            
        }
    }
}
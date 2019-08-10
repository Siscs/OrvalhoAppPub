using OrvalhoApp.Domain.Interfaces;
using OrvalhoApp.Domain.Models;
using OrvalhoApp.Infra.Data.Contexto;

namespace OrvalhoApp.Infra.Data.Repositories
{
    public class UnidadeMedidaRepository : BaseRepository<UnidadeMedida>, IUnidadeMedidaRepository
    {
        public UnidadeMedidaRepository(OrvalhoContext contexto)
            : base(contexto)
        {
            
        }
    }
}
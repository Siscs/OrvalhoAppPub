using OrvalhoApp.Domain.Models;
using OrvalhoApp.Domain.Interfaces;
using OrvalhoApp.Infra.Data.Contexto;

namespace OrvalhoApp.Infra.Data.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(OrvalhoContext contexto)
            : base(contexto)
        {
            
        }
    }
}
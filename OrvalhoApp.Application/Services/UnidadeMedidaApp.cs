using OrvalhoApp.Application.Interfaces;
using OrvalhoApp.Domain.Interfaces;
using OrvalhoApp.Domain.Models;

namespace OrvalhoApp.Application.Services
{
    public class UnidadeMedidaApp : BaseApp<UnidadeMedida>, IUnidadeMedidaApp
    {
        public UnidadeMedidaApp(IUnidadeMedidaRepository repositorio)
            : base(repositorio)
        {
            
        }
    }
}
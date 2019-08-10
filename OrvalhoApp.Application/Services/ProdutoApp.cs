using OrvalhoApp.Application.Interfaces;
using OrvalhoApp.Domain.Interfaces;
using OrvalhoApp.Domain.Models;

namespace OrvalhoApp.Application.Services
{
    public class ProdutoApp : BaseApp<Produto>, IProdutoApp
    {
        public ProdutoApp(IProdutoRepository repositorio) 
            : base(repositorio)
        {
        }
    }
}
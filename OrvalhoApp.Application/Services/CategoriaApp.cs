using System.Linq;
using System.Threading.Tasks;
using OrvalhoApp.Application.Interfaces;
using OrvalhoApp.Domain.Interfaces;
using OrvalhoApp.Domain.Models;

namespace OrvalhoApp.Application.Services
{
    public class CategoriaApp : BaseApp<Categoria>, ICategoriaApp
    {
        public CategoriaApp(ICategoriaRepository repositorio) 
        : base(repositorio)
        {
            
        }

    }
}
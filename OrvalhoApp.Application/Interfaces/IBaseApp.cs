using System.Linq;
using System.Threading.Tasks;

namespace OrvalhoApp.Application.Interfaces
{
    public interface IBaseApp<TEntity>
    {
        Task<TEntity> Obter(long id);
        IQueryable<TEntity> ObterTodos();
        void Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        void Remover(long id);
        Task<int> SaveChanges();
    }
}
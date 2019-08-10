using System.Linq;
using System.Threading.Tasks;
using OrvalhoApp.Application.Interfaces;
using OrvalhoApp.Domain.Interfaces;

namespace OrvalhoApp.Application.Services
{
    public class BaseApp<TEntity> : IBaseApp<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseApp(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
            
        }
        public void Adicionar(TEntity entity)
        {
             _repository.Adicionar(entity);
        }

        public void Atualizar(TEntity entity)
        {
            _repository.Atualizar(entity);
        }

        public async Task<TEntity> Obter(long id)
        {
            return await _repository.Obter(id);
        }

        public IQueryable<TEntity> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public void Remover(long id)
        {
            _repository.Remover(id);
        }

        public async Task<int> SaveChanges()
        {
            return await _repository.SaveChanges();
        }
    }
}
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrvalhoApp.Domain.Interfaces;
using OrvalhoApp.Infra.Data.Contexto;

namespace OrvalhoApp.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected OrvalhoContext _dbContexto;

        public DbSet<TEntity> _dbEntity { get; set; }
        
        public BaseRepository(OrvalhoContext contexto)
        {
            _dbContexto = contexto;
            _dbEntity = contexto.Set<TEntity>();
        }

        public async void Adicionar(TEntity entity)
        {
            await _dbEntity.AddAsync(entity);
        }

        public void Atualizar(TEntity entity)
        {
            _dbEntity.Update(entity);
        }

        public async Task<TEntity> Obter(long id)
        {
            return await _dbEntity.FindAsync(id);
        }

        public IQueryable<TEntity> ObterTodos()
        {
            return _dbEntity;
        }

        public void Remover(long id)
        {
            _dbEntity.Remove(_dbEntity.Find(id));
        }

        public async Task<int> SaveChanges()
        {
            return await _dbContexto.SaveChangesAsync();
        }
    }
}
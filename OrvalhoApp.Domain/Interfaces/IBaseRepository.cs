using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OrvalhoApp.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Obter(long id);
        IQueryable<TEntity> ObterTodos();
        void Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        void Remover(long id);
        Task<int> SaveChanges();
    }
    
}
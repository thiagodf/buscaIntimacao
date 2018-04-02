using System;

namespace BuscaIntimacao.Domain.Core.Interfaces.Repositories
{
    public interface IBaseRepositoryEntity<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(Guid Id);
        void Remove(Guid Id);
        void Update(TEntity obj);
        int SaveChanges();
    }
}

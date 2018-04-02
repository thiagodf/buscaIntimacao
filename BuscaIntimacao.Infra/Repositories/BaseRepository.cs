using BuscaIntimacao.Domain.Core.Interfaces.Repositories;
using BuscaIntimacao.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace BuscaIntimacao.Infra.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepositoryEntity<TEntity> where TEntity : class
    {
        protected EntityContext _eContext;
        protected DbSet<TEntity> DbSet;

        public BaseRepository(EntityContext eContext)
        {
            _eContext = eContext;
            DbSet = eContext.Set<TEntity>();
        }
        public TEntity GetById(Guid Id)
        {
            return DbSet.Find(Id);
        }
        public void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }
        public void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public void Remove(Guid Id)
        {
            DbSet.Remove(DbSet.Find(Id));
        }

        public int SaveChanges()
        {
            return _eContext.SaveChanges();
        }
        public void Dispose()
        {
            _eContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

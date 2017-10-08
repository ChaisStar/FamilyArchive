namespace FamilyArchive.Data.Repository
{
    using System;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using Model;

    public class RepositoryBase<T> where T: class, IDbEntity
    {
        private readonly FamilyArchiveContext _context;
        private DbSet<T> _dbSet;

        protected DbSet<T> DbSet => _dbSet ?? (_dbSet = _context.Set<T>());

        public RepositoryBase(IDbFactory dbFactory)
        {
            _context = dbFactory.Init();
        }

        protected void Add(T entity)
        {
            entity.Created = DateTime.UtcNow;
            entity.Updated = DateTime.UtcNow;
            DbSet.Add(entity);
        }

        protected void Update(T entity)
        {
            DbSet.Attach(entity);
            entity.Updated = DateTime.UtcNow;
            _context.Entry(entity).State = EntityState.Modified;
        }

        protected void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        protected void DeleteMany(IEnumerable<T> entities)
        {
            DbSet.RemoveRange(entities);
        }
    }
}
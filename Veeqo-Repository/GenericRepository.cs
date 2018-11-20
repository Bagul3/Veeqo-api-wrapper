using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using VeeqoRepository.Models;

namespace VeeqoRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll()//T is for table
            ;

        IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entity);
        void Edit(T entity);
        void Save();
        bool HasUnsavedChanges();
    }

    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected internal VeeqoDevContext Context { get; set; }

        protected internal GenericRepository()
        {
            Context = new VeeqoContextFactory().CreateDbContext(new[] { "" });
        }

        public virtual IQueryable<T> GetAll()//T is for table
        {

            IQueryable<T> query = this.Context.Set<T>();
            return query;
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            var query = this.Context.Set<T>().Where(predicate);
            return query;
        }

        public virtual void Add(T entity)
        {
            this.Context.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            this.Context.Set<T>().Remove(entity);
        }

        public virtual void DeleteRange(IEnumerable<T> entity)
        {
            this.Context.Set<T>().RemoveRange(entity);
        }

        public virtual void Edit(T entity)
        {
            this.Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            this.Context.SaveChangesAsync();
        }

        public bool HasUnsavedChanges()
        {
            return this.Context.ChangeTracker.Entries().Any(e => e.State == EntityState.Added
                                                                 || e.State == EntityState.Modified
                                                                 || e.State == EntityState.Deleted);
        }
    }
}

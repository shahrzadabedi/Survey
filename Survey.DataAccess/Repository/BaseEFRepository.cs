using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;



namespace Survey.DataAccess
{
   public class BaseEFRepository<TEntity> : IRepository<TEntity> where TEntity: class        
{
    internal DbContext context;
    internal DbSet<TEntity> dbSet;

    public BaseEFRepository(DbContext context)
    {
        this.context = context;
        this.dbSet = context.Set<TEntity>();
    }

    public  IEnumerable<TEntity> GetWithRawSql(string query,
        params object[] parameters)
    {
        return dbSet.SqlQuery(query, parameters).ToList();
    }

    public IEnumerable<TEntity> Get(
        Expression<Func<TEntity, bool>> filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, 
        params Expression<Func<TEntity, object>>[] includeProperties
        )
    {
        IQueryable<TEntity> query = dbSet;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        foreach (Expression<Func<TEntity, object>> includeProperty in includeProperties)
        {
            query = query.Include<TEntity, object>(includeProperty);
        }

            

            if (orderBy != null)
        {
            return orderBy(query).ToList();
        }
        else
        {
            return query.ToList();
        }
    }


        public async Task<IEnumerable<TEntity>> GetAsync(
        Expression<Func<TEntity, bool>> filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        params Expression<Func<TEntity, object>>[] includeProperties
        )
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (Expression<Func<TEntity, object>> includeProperty in includeProperties)
            {
                query = query.Include<TEntity, object>(includeProperty);
            }



            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }
        public TEntity GetByID(object id)
    {
        return dbSet.Find(id);
    }

    public void Insert(TEntity entity)
    {
        dbSet.Add(entity);
    }

    

        public void Delete(object id)
    {
        TEntity entityToDelete = dbSet.Find(id);
        Delete(entityToDelete);
    }

    public void Delete(TEntity entityToDelete)
    {
        if (context.Entry(entityToDelete).State == System.Data.Entity.EntityState.Detached)
        {
            dbSet.Attach(entityToDelete);
        }
        dbSet.Remove(entityToDelete);
    }

    public void Update(TEntity entityToUpdate)
    {
        dbSet.Attach(entityToUpdate);
        context.Entry(entityToUpdate).State = System.Data.Entity.EntityState.Modified;
           
        }

    public bool Any(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }
           return query.Any();
            
        }

      
    }
}

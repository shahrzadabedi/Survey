﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DataAccess
{
   public interface IRepository<TEntity>
   {
       void Delete(TEntity entityToDelete);
       void Delete(object id);
       IEnumerable<TEntity> Get(
           Expression<Func<TEntity, bool>> filter = null,
           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, 
           params Expression<Func<TEntity, object>>[] includeProperties
           );
       Task<IEnumerable<TEntity>> GetAsync(
           Expression<Func<TEntity, bool>> filter = null,
           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
           params Expression<Func<TEntity, object>>[] includeProperties
           );
        bool Any(Expression<Func<TEntity, bool>> filter = null);
        TEntity GetByID(object id);
       IEnumerable<TEntity> GetWithRawSql(string query,
           params object[] parameters);
       void Insert(TEntity entity);      
       void Update(TEntity entityToUpdate);
      
    }
}

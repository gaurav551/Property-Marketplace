using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace Nepalists.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
         void Create(T t);
         void Remove(Expression<Func<T,bool>> predicate);
         void Update(T t);
         List<T> GetAll();
         List<T> GetBy(Expression<Func<T,bool>> predicate);
         bool CheckIfExists(Expression<Func<T,bool>> predicate);
         T GetSingle(Expression<Func<T,bool>> predicate);




    }
}
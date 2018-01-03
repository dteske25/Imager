using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ExampleApp.Core.Models;

namespace ExampleApp.Core.Accessors
{
    public interface IMongoAccessor<T> where T : IBaseMongoObject
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> where);
        Task<T> Single(Expression<Func<T, bool>> where);
        Task<T> First(Expression<Func<T, bool>> where);
        Task Delete(Expression<Func<T, bool>> where);
        Task Delete(T entity);
        Task<T> Insert(T entity);
        Task InsertMany(IEnumerable<T> entities);
        Task Update(T entity);
    }
}

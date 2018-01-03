using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ExampleApp.Core.Accessors;
using ExampleApp.Core.Models;
using MongoDB.Driver;

namespace ExampleApp.Accessors.Infrastructure
{
    public abstract class MongoAccessor<T> : IMongoAccessor<T> where T : IBaseMongoObject
    {
        public readonly IMongoCollection<T> _collection;

        public MongoAccessor(MongoContext context)
        {
            _collection = context._database.GetCollection<T>(typeof(T).Name);
        }

        public async Task Delete(Expression<Func<T, bool>> where)
        {
            await _collection.DeleteManyAsync(where);
        }

        public async Task Delete(T entity)
        {
            await _collection.DeleteOneAsync(f => f.Id == entity.Id);
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> where)
        {
            var results = await _collection.FindAsync(where);
            return results.ToEnumerable();
        }

        public async Task<T> First(Expression<Func<T, bool>> where)
        {
            var results = await _collection.FindAsync(where);
            return results.FirstOrDefault();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var results = await _collection.AsQueryable().ToListAsync();
            return results;
        }

        public async Task<T> Insert(T entity)
        {
            await _collection.InsertOneAsync(entity);
            return entity;
        }

        public async Task InsertMany(IEnumerable<T> entities)
        {
            await _collection.InsertManyAsync(entities);
        }

        public async Task<T> Single(Expression<Func<T, bool>> where)
        {
            var results = await _collection.FindAsync(where);
            return results.SingleOrDefault();
        }

        public async Task Update(T entity)
        {
            await _collection.ReplaceOneAsync(e => e.Id == entity.Id, entity);
        }
    }
}

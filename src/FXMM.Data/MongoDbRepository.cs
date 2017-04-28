using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FXMM.Entity;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using MongoDB.Bson;

namespace FXMM.Data
{
    public class MongoDbRepository<T> : IRepository<T> where T : EntityBase
    {
        private readonly MongoDbContext context;
        string errorMossage = string.Empty;
        private IMongoDatabase _database;
        private string _collectionName;

        public MongoDbRepository(IOptions<MongoDbSettings> settings)
        {
            context = new MongoDbContext(settings);
            _database = context.Database;
            _collectionName = getName();
        }

        public string CollectionName { get { return getName(); } }

        private string getName()
        {
            return typeof(T).Name.ToLower();
        }

        private IMongoCollection<T> Collection
        {
            get { return _database.GetCollection<T>(CollectionName); }
        }

        private int GetNextValue()
        {
            return this.GetAll().LastOrDefault().Id + 1;
        }

        public async Task<DeleteResult> DeleteAsync(string Id)
        {
            return await this.Collection.DeleteOneAsync(Builders<T>.Filter.Eq("Id", Id));
        }

        public DeleteResult Delete(string Id)
        {
            return this.Collection.DeleteOne(Builders<T>.Filter.Eq("Id", Id));
        }

        public async Task<DeleteResult> DeleteAsync(Expression<Func<T, bool>> where)
        {
            return await Collection.DeleteOneAsync(where);
        }

        public DeleteResult Delete(Expression<Func<T, bool>> where)
        {
            return Collection.DeleteOne(where);
        }

        public Task<DeleteResult> DeleteAsync(T entity)
        {
            return this.DeleteAsync(entity.Id.ToString());
        }

        public DeleteResult Delete(T entity)
        {
            return this.Delete(entity.Id.ToString());
        }

        public DeleteResult DeleteAll()
        {
            return this.Collection.DeleteMany(new BsonDocument());
        }

        public async Task<DeleteResult> DeleteAllAsync()
        {
            return await this.Collection.DeleteManyAsync(new BsonDocument());
        }

        public bool Exists(Expression<Func<T, bool>> predicate)
        {
            return this.Collection.Count(predicate) > 0;
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return this.Collection.Find(where).FirstOrDefault();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> where)
        {
            return await this.Collection.Find(where).FirstOrDefaultAsync();
        }

        public async Task<T> GetAsync(string Id)
        {
	        var filter = Builders<T>.Filter.Eq("Id", Id);

	        return await this.Collection.Find(filter).FirstOrDefaultAsync();		
        }

        public T Get(string Id)
        {
            var filter = Builders<T>.Filter.Eq("Id", Id);

            return this.Collection.Find(filter).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return this.Collection.Find(_ => true).ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await this.Collection.Find(_ => true).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> where)
        {
            return await this.Collection.Find(where).ToListAsync();
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return this.Collection.Find(where).ToList();
        }

        public async Task InsertAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(CollectionName, "Object is null");

            await this.Collection.InsertOneAsync(entity);
        }

        public void Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(CollectionName, "Object is null");

            entity.Id = GetNextValue();

            this.Collection.InsertOne(entity);
        }

        public void RequestDone()
        {
            throw new NotImplementedException();
        }

        public IDisposable RequestStart()
        {
            throw new NotImplementedException();
        }

        public async Task<ReplaceOneResult> UpdateAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(CollectionName, "Object is null");

            return await this.Collection.ReplaceOneAsync(n => n.Id.Equals(entity.Id), 
							entity, 
							new UpdateOptions { IsUpsert = true });

        }

        public ReplaceOneResult Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(CollectionName, "Object is null");

            return this.Collection.ReplaceOne(n => n.Id.Equals(entity.Id),
                            entity,
                            new UpdateOptions { IsUpsert = true });

        }
    }
}

using FXMM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Linq.Expressions;
using Microsoft.Extensions.Options;

namespace FXMM.Data
{
    public class CountryRepository : ICountryRepository
    {
        private readonly MongoDbContext context;
        string errorMossage = string.Empty;
        private IMongoDatabase _database;
        private string _collectionName;

        private IMongoCollection<Country> Collection
        {
            get { return _database.GetCollection<Country>("country"); }
        }

        public DeleteResult Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public DeleteResult Delete(Expression<Func<Country, bool>> where)
        {
            throw new NotImplementedException();
        }

        public DeleteResult Delete(Country entity)
        {
            throw new NotImplementedException();
        }

        public DeleteResult DeleteAll()
        {
            throw new NotImplementedException();
        }

        public Task<DeleteResult> DeleteAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DeleteResult> DeleteAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteResult> DeleteAsync(Expression<Func<Country, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteResult> DeleteAsync(Country entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<Country, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Country Get(Expression<Func<Country, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Country Get(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> GetAll()
        {
            return this.Collection.Find(_ => true).ToList();
        }

        public Task<IEnumerable<Country>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Country> GetAsync(Expression<Func<Country, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<Country> GetAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> GetMany(Expression<Func<Country, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Country>> GetManyAsync(Expression<Func<Country, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Insert(Country entity)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Country entity)
        {
            throw new NotImplementedException();
        }

        public void RequestDone()
        {
            throw new NotImplementedException();
        }

        public IDisposable RequestStart()
        {
            throw new NotImplementedException();
        }

        public ReplaceOneResult Update(Country entity)
        {
            throw new NotImplementedException();
        }

        public Task<ReplaceOneResult> UpdateAsync(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}

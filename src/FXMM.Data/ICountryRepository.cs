using FXMM.Entity;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FXMM.Data
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetAllAsync();
        Task<Country> GetAsync(string Id);
        Task<Country> GetAsync(Expression<Func<Country, bool>> where);
        Task<IEnumerable<Country>> GetManyAsync(Expression<Func<Country, bool>> where);
        Task InsertAsync(Country entity);
        Task<ReplaceOneResult> UpdateAsync(Country entity);
        Task<DeleteResult> DeleteAsync(Country entity);
        Task<DeleteResult> DeleteAsync(string Id);
        Task<DeleteResult> DeleteAsync(Expression<Func<Country, bool>> where);
        Task<DeleteResult> DeleteAllAsync();

        IEnumerable<Country> GetAll();
        Country Get(string Id);
        Country Get(Expression<Func<Country, bool>> where);
        IEnumerable<Country> GetMany(Expression<Func<Country, bool>> where);
        void Insert(Country entity);
        ReplaceOneResult Update(Country entity);
        DeleteResult Delete(Country entity);
        DeleteResult Delete(string Id);
        DeleteResult Delete(Expression<Func<Country, bool>> where);
        DeleteResult DeleteAll();

        bool Exists(Expression<Func<Country, bool>> predicate);
    }
}

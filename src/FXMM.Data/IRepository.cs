using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FXMM.Entity;
using MongoDB.Driver;

namespace FXMM.Data
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int Id);
        Task<T> GetAsync(Expression<Func<T, bool>> where);
        Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> where);
        Task InsertAsync(T entity);
        Task<ReplaceOneResult> UpdateAsync(T entity);
        Task<DeleteResult> DeleteAsync(T entity);
        Task<DeleteResult> DeleteAsync(int Id);
        Task<DeleteResult> DeleteAsync(Expression<Func<T, bool>> where);
        Task<DeleteResult> DeleteAllAsync();

        IEnumerable<T> GetAll();
        T Get(int Id);
        T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        void Insert(T entity);
        ReplaceOneResult Update(T entity);
        DeleteResult Delete(T entity);
        DeleteResult Delete(int Id);
        DeleteResult Delete(Expression<Func<T, bool>> where);
        DeleteResult DeleteAll();

        bool Exists(Expression<Func<T, bool>> predicate);

        IDisposable RequestStart();

        void RequestDone();
    }
}

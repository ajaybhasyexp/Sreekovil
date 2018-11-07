using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DivineAccounts.Model.Repository
{
    /// <summary>
    /// The interface for repository of the models.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById(int Id);

        T Insert(T entity);

        IEnumerable<T> InsertMultiple(IEnumerable<T> obj);

        void Update(T entity);

        void Delete(int Id);

        void Save();

        IEnumerable<T> Collect(Expression<Func<T, bool>> filter);
    }
}

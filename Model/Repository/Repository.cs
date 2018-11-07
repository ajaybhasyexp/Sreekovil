using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DivineAccounts.Model.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DAContext db;
        private DbSet<T> dbSet;

        public Repository()
        {
            db = new DAContext();
            dbSet = db.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(int Id)
        {
            return dbSet.Find(Id);
        }

        public T Insert(T obj)
        {
            dbSet.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public IEnumerable<T> InsertMultiple(IEnumerable<T> obj)
        {
            dbSet.AddRange(obj);
            db.SaveChanges();
            return obj;
        }

        public void Update(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(int Id)
        {
            T getObjById = dbSet.Find(Id);
            dbSet.Remove(getObjById);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<T> Collect(Expression<Func<T, bool>> filter)
        {
            return dbSet.Where(filter).ToList();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.db != null)
                {
                    this.db.Dispose();
                    this.db = null;
                }
            }
        }


    }
}

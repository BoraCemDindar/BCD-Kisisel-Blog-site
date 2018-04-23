using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext; //Veritabanı(ent)
        private readonly DbSet<T> _dbSet; //Tablo (ent.TabloAdı gibi)
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        public bool Ekle(T item)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            IQueryable<T> sorgu = _dbSet;
            if (filter != null)
            {
                sorgu = sorgu.Where(filter);
            }
            if (orderBy != null)
            {
                sorgu = orderBy(sorgu);
            }
            return sorgu.ToList();
            if (filter != null & orderBy != null)
            {
                sorgu = sorgu.Where(filter);
                sorgu = orderBy(sorgu);
            }
            return sorgu.ToList();

        }

        public bool Guncelle(T item)
        {
            throw new NotImplementedException();
        }

        public IList<T> Listele()
        {
            return _dbSet.ToList();
        }

        public T Sec(string ItemName)
        {
            throw new NotImplementedException();
        }

        public T Sec(int itemID)
        {
            return _dbSet.Find(itemID);
        }

        public bool Sil(int itemID)
        {
            throw new NotImplementedException();
        }

        public bool Sil(T item)
        {
            throw new NotImplementedException();
        }
    }
}
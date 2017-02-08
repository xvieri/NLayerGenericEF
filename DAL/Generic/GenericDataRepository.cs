using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL.Generic
{
    public class GenericDataRepository<T> : IGenericDataRepository<T> where T : class
    {
        public virtual IList<T> GetAll()
            {
            List<T> list;
            using (var context = new ColegioEntities())
            {
                IQueryable<T> dbQuery = context.Set<T>();
                list = dbQuery.ToList<T>();
            }
            return list;
        }

        public virtual T Find(Expression<Func<T, bool>> where)
        {
            T item = null;
            using (var context = new ColegioEntities())
            {
                IQueryable<T> dbQuery = context.Set<T>();
                item = dbQuery.Where(where).ToList().FirstOrDefault<T>(); 
            }
            return item;
        }

        public void Add(params T[] items)
        {
            using (var context = new ColegioEntities())
            {
                foreach (T item in items)
                {
                    context.Entry(item).State = EntityState.Added;
                }
                context.SaveChanges();
            }
        }

        public void Update(params T[] items)
        {
            using (var context = new ColegioEntities())
            {
                foreach (T item in items)
                {
                    context.Entry(item).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public void Remove(params T[] items)
        {
            using (var context = new ColegioEntities())
            {
                foreach (T item in items)
                {
                    context.Entry(item).State = EntityState.Deleted;
                }
                context.SaveChanges();
            }
        }
    }
}

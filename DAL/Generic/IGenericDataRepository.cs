using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Generic
{
    public interface IGenericDataRepository<T> where T : class
    {
        IList<T> GetAll();
        T Find(Expression<Func<T, bool>> where);
        void Add(params T[] items);
        void Update(params T[] items);
        void Remove(params T[] items);
    }
}

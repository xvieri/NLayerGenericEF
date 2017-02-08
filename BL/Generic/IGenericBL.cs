using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL.crud
{
    public interface IGenericBL<T> where T:class
    {
        IList<T> GetAll();
        T Find(Expression<Func<T, bool>> expresion);
        void Add(params T[] items);
        void Update(params T[] itemsy);
        void Remove(params T[] items);

    }
}

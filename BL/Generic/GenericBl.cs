using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DAL.Dao;
using DAL.Generic;

namespace BL.crud
{
    public class GenericBl<T> : IGenericBL<T> where T : class
    {
        public GenericDataRepository<T> _repository;
      
        public GenericBl(GenericDataRepository<T> _repo)
        {
            _repository = _repo;
        }

       
        public void Add(params T[] items)
        {
           _repository.Add(items);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T Find(Expression<Func<T, bool>> expresion)
        {
            return _repository.Find(expresion);
        }

        public void Remove(params T[] items)
        {
            _repository.Remove(items);
        }

        public void Update(params T[] items)
        {
            _repository.Update(items);

        }
    }
}

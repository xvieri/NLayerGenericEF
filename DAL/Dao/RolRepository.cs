using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Generic;
using Entity;

namespace DAL.Dao
{
    public interface IRolRepository: IGenericDataRepository<Rol>
    {
    }
    
    public class RolRepository : GenericDataRepository<Rol>, IRolRepository
    {
        public void InsertBySq(string nombre)
        {
            using (var context = new ColegioEntities())
            {
                context.sp_insert_rol(nombre);
                context.SaveChanges();
            }
            
        }
    }
}

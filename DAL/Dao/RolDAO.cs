using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL.Dao
{
    public class RolDAO
    {
        public List<Rol> GetRolList()
        {
            using (ColegioEntities db= new ColegioEntities())
            {
                var result = db.Rols.ToList();
                return result;
            }
        }
    }
}

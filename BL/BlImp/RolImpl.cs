using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.crud;
using DAL.Dao;
using Entity;

namespace BL.BlImp
{
    public class RolImpl : GenericBl<Rol>
    {
        public RolImpl() :
            base(new RolRepository())
        {

        }

        public void InsertSp(string nombre)
        {
            //RolRepository re = new RolRepository();
            //re.InsertBySq(nombre);
            ((RolRepository)_repository).InsertBySq(nombre);
            
        }
    }
}

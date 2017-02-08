using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.crud;
using DAL.Dao;
using DAL.Generic;
using Entity;

namespace BL.BlImp
{
    public class UsuarioImp: GenericBl<Usuario>
    {
        public UsuarioImp() : base(new UsuarioRepository())
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Generic;
using Entity;

namespace DAL.Dao
{
    public interface IUsuarioRepository: IGenericDataRepository<Usuario>
    {
    }

    public class UsuarioRepository : GenericDataRepository<Usuario>, IUsuarioRepository
    {
    }
}

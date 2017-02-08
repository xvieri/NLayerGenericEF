using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.crud;
using DAL.Generic;
using Entity;

namespace BL.BlImp
{
    class CursoImp : GenericBl<Curso>
    {
        public CursoImp(GenericDataRepository<Curso> _repository) : base(_repository)
        {
        }
    }
}

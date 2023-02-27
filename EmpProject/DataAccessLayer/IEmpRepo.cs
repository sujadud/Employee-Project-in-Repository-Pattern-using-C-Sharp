using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProject.DAL
{
    public interface IEmpRepo
    {
        List<Emp> Get();
        Emp Get(int id);
        bool Add(Emp emp);
        bool Update(Emp emp);
        bool Delete(int id);
    }
}

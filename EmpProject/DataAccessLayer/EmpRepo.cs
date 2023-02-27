using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProject.DAL
{
    internal class EmpRepo : IEmpRepo
    {
        List<Emp> EmpList = new List<Emp>()
        {
            new Emp(1, "Abdulla", "Dhaka, Bangladesh"),
            new Emp(2, "Tarik", "Dinajpur, Bangladesh"),
            new Emp(3, "Al-Mamun", "Gazipur, Bangladesh"),
            new Emp(4, "Kawser", "Faridpur, Bangladesh")

        };
        public List<Emp> Get()
        {
            return EmpList.OrderBy(x => x.Name).ToList();
        }
        public Emp Get(int id)
        {
            Emp oEmp = EmpList.Where(x => x.ID == id).FirstOrDefault();
            return oEmp;
        }
        public bool Add(Emp emp)
        {
            EmpList.Add(emp);
            return true;
        }

        public bool Update(Emp emp)
        {
            bool isExecuted = false;
            Emp oEmp = EmpList.Where(x => x.ID == emp.ID).FirstOrDefault();
            if (oEmp != null)
            {
                EmpList.Remove(oEmp);
                EmpList.Add(emp);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete(int id)
        {
            bool isExecuted = false;
            Emp oEmp = EmpList.Where(x => x.ID == id).FirstOrDefault();
            if (oEmp != null)
            {
                EmpList.Remove(oEmp);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}

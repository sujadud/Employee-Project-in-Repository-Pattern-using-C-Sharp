using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProject.DAL
{
    public class Emp
    {
        public int ID;
        public string Name;
        public string Address;
        public Emp()
        {
        }
        public Emp(int id, string name, string address)
        {
            ID = id;
            Name = name;
            Address = address;
        }
    }
}

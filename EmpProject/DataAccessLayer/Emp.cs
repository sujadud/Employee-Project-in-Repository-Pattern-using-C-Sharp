using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProject.DAL
{
    public class Emp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

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

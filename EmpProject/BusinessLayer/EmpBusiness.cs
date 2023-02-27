using EmpProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmpProject.BL
{
    public class EmpBusiness
    {
        IEmpRepo _repository;

        public EmpBusiness(IEmpRepo repo)
        {
            _repository = repo;
        }
        public List<Emp> Get()
        {
            return _repository.Get();
        }
        public Emp Get(int id)
        {
            return _repository.Get(id);
        }
        public bool Add(Emp emp)
        {
            return _repository.Add(emp);
        }
        public bool Update(Emp emp)
        {
            return _repository.Update(emp);
        }
        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}

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
            List<Emp> response = _repository.Get();
            return response.OrderBy(x => x.ID).ToList();
        }

        public Emp Get(int id)
        {
            return _repository.Get(id);
        }

        public bool Create(Emp emp)
        {
            return _repository.Create(emp);
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

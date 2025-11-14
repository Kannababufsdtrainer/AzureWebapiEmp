using EmpCrud.Models;
using EmpCrud.Repo;

namespace EmpCrud.SL
{
    public class EmpService : IEmpService
    {
        private readonly IEmpRepo emprepo;
        public EmpService(IEmpRepo emprepo)
        {
            this.emprepo = emprepo;
        }
        public void Add(Employee emp)
        {
            emprepo.Add(emp);
        }

        public void Delete(int id)
        {
         
        }

        public Employee GetById(int id)
        {
         return emprepo.GetById(id);
        }
        public List<Employee> GetEmps()
        {
            return emprepo.GetEmps();
        }
        public void Update(Employee emp)
        {
            throw new NotImplementedException();
        }
    }
}

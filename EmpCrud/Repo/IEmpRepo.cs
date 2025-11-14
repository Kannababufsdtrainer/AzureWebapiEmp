using EmpCrud.Models;

namespace EmpCrud.Repo
{
    public interface IEmpRepo
    {
        List<Models.Employee> GetEmps();
        Employee GetById(int id);
        void Add(Employee emp);
        void Update(Employee emp);  
        void Delete(int id);
    }
}

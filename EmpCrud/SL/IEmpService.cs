using EmpCrud.Models;

namespace EmpCrud.SL
{
    public interface IEmpService
    {
        List<Models.Employee> GetEmps();
        Employee GetById(int id);
        void Add(Employee emp);
        void Update(Employee emp);
        void Delete(int id);
    }
}

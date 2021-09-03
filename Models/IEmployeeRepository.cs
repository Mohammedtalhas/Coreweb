using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coreweb.Models
{
    public interface IEmployeeRepository
    {
        void AddEmployee(Employee newEmployee);
        Employee GetEmployee(int id);
        List<Employee> GetEmployees();
        void UpdateEmployee(Employee e);
        void DeleteEmployee(int id);

    }
}

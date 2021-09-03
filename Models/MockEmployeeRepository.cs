using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coreweb.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        List<Employee> employees = new List<Employee>();
        public void AddEmployee(Employee newEmployee)
        {
            employees.Add(newEmployee);
        }

        public void DeleteEmployee(int id)
        {
            Employee e = employees.SingleOrDefault(emp => emp.EMPID == id);
            employees.Remove(e);
        }

        public Employee GetEmployee(int id)
        {
            return employees.SingleOrDefault(emp => emp.EMPID == id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void UpdateEmployee(Employee e)
        {
           
        }
    }
}

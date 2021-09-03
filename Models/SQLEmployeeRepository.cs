using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coreweb.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly DatabaseContext context;

        public SQLEmployeeRepository(DatabaseContext context)
        {
            this.context = context;
        }
        public void AddEmployee(Employee newEmployee)
        {
            context.employees.Add(newEmployee);
            context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            Employee e = context.employees.SingleOrDefault(emp => emp.EMPID == id);
            context.employees.Remove(e);
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            return context.employees.ToList();
        }

        public void UpdateEmployee(Employee e)
        {
            throw new NotImplementedException();
        }
    }
}

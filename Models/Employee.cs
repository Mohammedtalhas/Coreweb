using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coreweb.Models
{
    public class Employee
    {
        [Key]
        public int EMPID { get; set; }
        public string ename { get; set; }
        public string location { get; set; }
        public string designation { get; set; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee(){EMPID=123,ename="Swati",location="Pune",designation="Campus Hire Technical Lead"},
                 new Employee(){EMPID=124,ename="Swati",location="Pune",designation="Campus Hire Technical Lead"}
            };
            return list;
        }
    }
}

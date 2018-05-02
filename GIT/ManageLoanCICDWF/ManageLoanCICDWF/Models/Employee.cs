using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageLoanCICDWF.Models
{
    public class Employee
    {
        public string EmpID { get; set; }

        public string EmpName { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public string Hierarchy { get; set; }
    }

    public class EmployeeCollection
    {
        public List<Employee> EmployeeList { get; set; }
    }
}
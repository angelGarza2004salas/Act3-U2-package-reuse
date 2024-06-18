using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem.Models
{
    public class Assignment
    {
        public Employee Employee { get; set; }
        public Department Department { get; set; }
        public DateTime DateAssignment { get; set; }

        public Assignment(Employee employee, Department department, DateTime dateAssignment)
        {
            Employee = employee;
            Department = department;
            DateAssignment = dateAssignment;
        }
    }
}

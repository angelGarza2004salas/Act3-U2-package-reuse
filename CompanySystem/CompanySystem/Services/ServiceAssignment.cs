using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem.Services
{
    using CompanySystem.Models;
    using System.Collections.Generic;
    public class ServiceAssignment
    {
        private List<Assignment> assignments = new List<Assignment>();

        public void AddAssignment(Assignment assignment)
        {
            assignments.Add(assignment);
        }

        public List<Assignment> ObtainAssignments()
        {
            return assignments;
        }

    }
}

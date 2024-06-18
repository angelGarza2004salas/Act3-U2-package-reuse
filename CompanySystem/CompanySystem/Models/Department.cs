using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem.Models
{
    public class Department
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public Department(string nombre, string codigo)
        {
            Nombre = nombre;
            Codigo = codigo;
        }
    }
}

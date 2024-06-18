using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem.Models
{
    public class Employee
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string ID { get; set; }

        public Employee(string nombre, string apellido, string id)
        {
            Nombre = nombre;
            Apellido = apellido;
            ID = id;
        }
    }
}

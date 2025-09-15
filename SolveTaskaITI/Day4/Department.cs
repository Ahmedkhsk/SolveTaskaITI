using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day4
{
    public class Department
    {
        public string Name { get; set; } = string.Empty;
        public List<Person> Employees { get; set; }
        public Department(string name)
        {
            Name = name;
            Employees = new List<Person>();
        }
    }
}

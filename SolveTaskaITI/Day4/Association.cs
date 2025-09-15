using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day4
{
    class Emloyee2
    {
        public string Name { get; set; } = default!;
        public int Age { get; set; }
        public List<Course2> Courses { get; set; } = default!;
    }

    class Course2
    {
        public string CourseName { get; set; } = default!;
        public List<Emloyee2> Emloyees { get; set; } = default!;
    }

}

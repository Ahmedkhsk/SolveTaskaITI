using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day4
{
    class Car
    {
        public string Model { get; set; } = default!;
        public Engine Engine { get; set; } = default!;
    }
    class Engine
    {
        public string Type { get; set; } = default!;
        public int HorsePower { get; set; }
    }
}

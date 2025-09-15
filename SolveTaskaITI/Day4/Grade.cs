using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day4
{
    public class Grade
    {
        public int value { get; set; }

        public static Grade operator +(Grade g1, Grade g2)
        {
            return new Grade { value = g1.value + g2.value };
        }

        public static bool operator ==(Grade g1, Grade g2)
        {
            return g1.value == g2.value;
        }
        public static bool operator !=(Grade g1, Grade g2)
        {
            return g1.value != g2.value;
        }

        public override bool Equals(object obj)
        {
            if (obj is Grade grade)
                return value == grade.value;
            return false;
        }

    }
}

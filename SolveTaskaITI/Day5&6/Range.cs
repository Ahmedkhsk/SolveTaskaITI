using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day5_6
{
    public class Range<T> where T : IComparable<T>
    {
        public T MinValue { get; set; }
        public T MaxValue { get; set; }
        public Range(T minValue, T maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }


        public bool IsInRange(T value)
        {
            return value.CompareTo(MinValue) >= 0 && value.CompareTo(MaxValue) <= 0;
        }

        public double Length()
        {
            try
            {
                double min = Convert.ToDouble(MinValue);
                double max = Convert.ToDouble(MaxValue);
                return max - min;
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Length calculation is not supported for the given type.");
            }
        }
    }
}

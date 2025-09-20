using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day5_6
{
    public static class ReverseArrayList
    {
        public static void Reverse(ArrayList arrayList)
        {
            int left = 0;
            int right = arrayList.Count - 1;

            while (left < right)
            {
                object temp = arrayList[left]!;
                arrayList[left] = arrayList[right];
                arrayList[right] = temp;
                left++;
                right--;
            }
        }
    }
}

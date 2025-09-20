using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day5_6
{
    public static class BubbleSortAlgorithm
    {
        public static void BubbleSort(int[] arr)
        {
            int arrLength = arr.Length;
            bool swapped;
            for (int i = 0; i < arrLength - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < arrLength - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
    }
}

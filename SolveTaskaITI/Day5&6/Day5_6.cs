using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day5_6
{
    public static class Day5_6
    {
        public static void BubbleSortDemo()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Original array: " + string.Join(", ", arr));
            BubbleSortAlgorithm.BubbleSort(arr);
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }
        public static void RangeDemo()
        {
            Range<int> intRange = new Range<int>(1, 10);
            Console.WriteLine($"Integer Range: {intRange.MinValue} to {intRange.MaxValue}");
            Console.WriteLine($"Is 5 in range? {intRange.IsInRange(5)}");
            Console.WriteLine($"Length of range: {intRange.Length()}");
            Range<double> doubleRange = new Range<double>(1.5, 10.5);
            Console.WriteLine($"\nDouble Range: {doubleRange.MinValue} to {doubleRange.MaxValue}");
            Console.WriteLine($"Is 7.2 in range? {doubleRange.IsInRange(7.2)}");
            Console.WriteLine($"Length of range: {doubleRange.Length()}");
            Range<char> charRange = new Range<char>('a', 'z');
            Console.WriteLine($"\nCharacter Range: {charRange.MinValue} to {charRange.MaxValue}");
            Console.WriteLine($"Is 'm' in range? {charRange.IsInRange('m')}");
            try
            {
                Console.WriteLine($"Length of range: {charRange.Length()}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error calculating length for char range: {ex.Message}");
            }
        }
        public static void ReveseDem()
        {
            ArrayList arr = new ArrayList() { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original ArrayList:");
            foreach (var item in arr)
                Console.Write(item + " ");

            ReverseArrayList.Reverse(arr);

            Console.WriteLine("\nReversed ArrayList:");
            foreach (var item in arr)
                Console.Write(item + " ");
        }
        public static void GetEvenNumbers()
        {
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = Numbers.FindAll(n => n % 2 == 0);
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
        }
        public static void FixedSizeListDemo()
        {
            FixedSizeList<int> fixedList = new FixedSizeList<int>(5);
            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    fixedList.Add(i);
                    Console.WriteLine($"Added {i} to the list.");
                }
                fixedList.Add(6);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Current items in the list:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(fixedList.GetValue(i));
            }
        }

        public static void FirstNonRepatedCharDemo()
        {
            string input1 = "swiss";
            string input2 = "aabbcc";
            string input3 = "leetcode";

            Console.WriteLine($"Input: {input1}, First Non-Repeated Index: {FirstNonRepeatedChar.FindFirstNonRepeatedChar(input1)}"); 
            Console.WriteLine($"Input: {input2}, First Non-Repeated Index: {FirstNonRepeatedChar.FindFirstNonRepeatedChar(input2)}"); 
            Console.WriteLine($"Input: {input3}, First Non-Repeated Index: {FirstNonRepeatedChar.FindFirstNonRepeatedChar(input3)}"); 
        }

    }
}

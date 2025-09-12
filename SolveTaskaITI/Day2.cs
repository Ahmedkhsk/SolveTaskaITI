using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI
{
    public static class Day2
    {
        public static void InputPrintStudentNames()
        {
            Console.Write("Enter Number of Students: ");
            int n = int.Parse(Console.ReadLine()!);
            string[] names = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter Name of Student {i + 1}: ");
                names[i] = Console.ReadLine()!;
            }

            Console.WriteLine("Student Names are: ");
            foreach (string name in names) 
                Console.WriteLine(name);

        }

        public static void InputPrintCalculateAverageStudentAges()
        {
            Console.Write("Enter Number of Tracks: ");
            int t = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Number of Students: ");
            int s = int.Parse(Console.ReadLine()!);

            int[,] ages = new int[t,s];

            for(int i = 0; i < ages.GetLength(0); i++)
            {
                for (int j = 0; j < ages.GetLength(1); j++)
                {
                    Console.Write($"Enter Age of Student {j + 1} in Track {i + 1}: ");
                    ages[i, j] = int.Parse(Console.ReadLine()!);
                }
            }

            Console.WriteLine("\nStudent Ages:");
            for (int i = 0; i < ages.GetLength(0); i++)
            {
                Console.Write($"Track {t + 1}: ");
                for (int j = 0; j < ages.GetLength(1) ; j++)
                {
                    Console.Write($"{ages[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nAverage Age per Track:");
            for (int i = 0; i < ages.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < ages.GetLength(1); j++)
                {
                    sum += ages[i, j];
                }
                double avg = (double)sum / ages.GetLength(1);
                Console.WriteLine($"Track {i + 1}: {avg:F2}");
            }

        }
    
        public static void TimeToSeconds()
        {
            Time t = new Time();
            
            Console.Write("Enter Hours: ");
            t.hours = double.Parse(Console.ReadLine()!);

            Console.Write("Enter Minutes: ");
            t.minutes = double.Parse(Console.ReadLine()!);
            
            Console.Write("Enter Seconds: ");
            t.seconds = double.Parse(Console.ReadLine()!);
                
            Console.WriteLine($"{t.hours}H:{t.minutes}M:{t.seconds}S");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day7
{
    public static class Day7
    {
        public static void ProductDemo()
        {
            var product = Product.CreateProduct();
            Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price}");
        }

        public static int countString(this string s)
        {
            return s.Split(',').Length;
        }

        public static void countStringDemo()
        {
            string s = "apple,banana,cherry";
            int count = s.countString();
            Console.WriteLine($"The string contains {count} items.");
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static void IsEvenDemo()
        {
            int number = 4;
            bool isEven = number.IsEven();
            Console.WriteLine($"{number} is even: {isEven}");
        }

        public static int Age(this DateTime dateTime)
        {
            return DateTime.Now.Year - dateTime.Year;
        }
       
        public static void AgeDemo()
        {
            DateTime birthDate = new DateTime(1990, 1, 1);
            int age = birthDate.Age();
            Console.WriteLine($"Age is: {age}");
        }

        public static string ReverseString(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return new string(str.Reverse().ToArray());
        }
      
        public static void ReverseStringDemo()
        {
            string original = "Hello, World!";
            string reversed = original.ReverseString();
            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"Reversed: {reversed}");
        }
    
    }
}

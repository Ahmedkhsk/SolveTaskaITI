namespace SolveTaskaITI.Day1
{
    public static class Day1
    {
        public static void CharToAscii()
        {
            Console.Write("Enter Char: ");
            char ch = Console.ReadLine()![0];
            int ascii = ch;
            Console.WriteLine($"Asci Code Of {ch} is {ascii}");
        }
        public static void AsciiToChar()
        {
            Console.Write("Enter ASCII Code: ");
            int asciiCode = int.Parse(Console.ReadLine()!);
            char character = (char)asciiCode;
            Console.WriteLine($"Character of ASCII {asciiCode} is {character}");
        }

        public static void CheckOddEven()
        {

            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine()!);
            if (number % 2 == 0)
                Console.WriteLine($"{number} is Even");
            else
                Console.WriteLine($"{number} is Odd");
        }

        public static void BasicOperations()
        {
            Console.Write("Enter First Number: ");
            double num1 = double.Parse(Console.ReadLine()!);
            Console.Write("Enter Second Number: ");
            double num2 = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"Sum: {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1 * num2}");
        }

        public static void CalculateGrade()
        {
            Console.Write("Enter Your Degree: ");
            int degree = int.Parse(Console.ReadLine()!);

            var grade = degree switch
            {
                >= 90 and <= 100 => "A",
                >= 80 and < 90 => "B",
                >= 70 and < 80 => "C",
                >= 60 and < 70 => "D",
                >= 0 and < 60 => "F",
                _ => "Invalid Degree"
            };
            Console.WriteLine($"Grade: {grade}");
        }

        public static void MultiplicationTable()
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
        }        
    }
}

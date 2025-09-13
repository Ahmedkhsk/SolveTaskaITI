namespace SolveTaskaITI.Day3
{
    public static class Day3
    {
        public static void Calc()
        {
            Calc c = new Calc();

            Console.WriteLine("Sum int: " + c.Sum(5, 3));
            Console.WriteLine("Sum double: " + c.Sum(5.2, 3.3));
            Console.WriteLine("Sum string: " + c.Sum("Hello ", "World"));
            Console.WriteLine("Sub: " + c.Sub(10, 3));
            Console.WriteLine("Mul: " + c.Mul(4, 2));
            Console.WriteLine("Div: " + c.Div(10, 2));
        }

        public static void Question()
        {
            Console.Write("How many questions do you want to enter? ");
            int n = int.Parse(Console.ReadLine()!);
            Question[] Quiz = new MCQ[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter Question {i + 1}:");
                Console.Write("Header: ");
                string header = Console.ReadLine()!;

                Console.Write("Body: ");
                string body = Console.ReadLine()!;

                Console.Write("Mark: ");
                int mark = int.Parse(Console.ReadLine()!);

                Console.Write("How many choices? ");
                int c = int.Parse(Console.ReadLine()!);
                string[] choices = new string[c];

                for (int j = 0; j < c; j++)
                {
                    Console.Write($"Choice {j + 1}: ");
                    choices[j] = Console.ReadLine()!;
                }

                Console.Write("Enter correct choice number: ");
                int correct = int.Parse(Console.ReadLine()!);

                Quiz[i] = new MCQ(header, body, mark, choices, correct);
    
            }

            Console.WriteLine("\nYour Quiz:");
            
            int totalMark = 0;
            for (int i = 0; i < Quiz.Length; i++)
            {
                Console.WriteLine(Quiz[i].Show());
                Console.Write("Enter your answer (choice number): ");
                int answer = int.Parse(Console.ReadLine()!);
                if (answer == ((MCQ)Quiz[i]).CorrectAnswer)
                {
                    totalMark += Quiz[i].Mark;
                    Console.WriteLine("Correct!\n");
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer is choice number {((MCQ)Quiz[i]).CorrectAnswer}\n");

                }
            }
            Console.WriteLine($"Your total mark is: {totalMark}");
        }
    }
}

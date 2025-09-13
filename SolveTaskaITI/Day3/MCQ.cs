namespace SolveTaskaITI.Day3
{
    internal class MCQ : Question
    {
        public string[] Choices { get; set; }
        public int CorrectAnswer { get; set; }

        public MCQ(string header, string body, int mark, string[] choices, int correctAnswer)
            : base(header, body, mark)
        {
            Choices = choices;
            CorrectAnswer = correctAnswer;
        }

        public override string Show()
        {
            string q = base.Show() + "\nChoices:";
            for (int i = 0; i < Choices.Length; i++)
            {
                q += $"\n{i + 1}. {Choices[i]}";
            }
            return q;
        }
    }
}

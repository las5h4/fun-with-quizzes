using System;
using System.Linq;

namespace fun_with_quizzes
{
    public class MultipleChoiceQuestion : Question
    {
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }

        public MultipleChoiceQuestion()
        {
        }

        public MultipleChoiceQuestion(string questionBody, string optionA, string optionB, string optionC, string optionD, string correctAnswer) : base(questionBody, correctAnswer)
        {
            OptionA = optionA;
            OptionB = optionB;
            OptionC = optionC;
            OptionD = optionD;
        }

        public override string GetQuestionType()
        {
            return "MULTIPLE CHOICE";
        }

        public override string PrintOptions()
        {
            return $"A.) {OptionA}\nB.) {OptionB}\nC.) {OptionC}\nD.) {OptionD}\n";
        }

        public override string GetAnswer()
        {
            string answer = Console.ReadLine();
            string[] answers = { "A", "B", "C", "D" };
            while (!answers.Contains(answer.ToUpper()))
            {
                Console.WriteLine("Invalid input. Enter A, B, C, or D:");
                answer = Console.ReadLine();
            }
            return answer;
        }

        public void AddOptions()
        {
            Console.WriteLine("Please type option A:");
            OptionA = Console.ReadLine();
            Console.WriteLine("Please type option B:");
            OptionB = Console.ReadLine();
            Console.WriteLine("Please type option C:");
            OptionC = Console.ReadLine();
            Console.WriteLine("Please type option D:");
            OptionD = Console.ReadLine();
        }
    }
}

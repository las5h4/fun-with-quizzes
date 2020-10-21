using System;
using System.Linq;

namespace fun_with_quizzes
{
    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion()
        {
        }

        public TrueOrFalseQuestion(string questionBody, string correctAnswer) : base(questionBody, correctAnswer)
        {
        }

        public override string GetQuestionType()
        {
            return "TRUE OR FALSE";
        }

        public override string PrintOptions()
        {
            return "Type TRUE of FALSE:\n";
        }

        public override string GetAnswer()
        {
            Console.WriteLine("Type the letter of the ")
            string answer = Console.ReadLine();
            string[] answers = { "TRUE", "FALSE" };
            while (!answers.Contains(answer.ToUpper()))
            {
                Console.WriteLine("Invalid input. Enter TRUE or FALSE:");
                answer = Console.ReadLine();
            }
            return answer;
        }
    }
}

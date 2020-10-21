using System;
namespace fun_with_quizzes
{
    public class CheckboxQuestion : MultipleChoiceQuestion
    {
        public CheckboxQuestion()
        {
        }

        public CheckboxQuestion(string questionBody, string optionA, string optionB, string optionC, string optionD, string correctAnswer) : base(questionBody, optionA, optionB, optionC, optionD, correctAnswer)
        {
        }

        public override string GetQuestionType()
        {
            return "CHECKBOX";
        }

        public override string GetAnswer()
        {
            string answer = "";
            while (answer.Length <= 1)
            {
                Console.WriteLine("Please enter the letters of the correct options");
                string answerInput = Console.ReadLine().ToUpper();
                answer = "";
                string answers = "aAbBcCdD";
                foreach (char character in answerInput)
                {
                    if (!answer.Contains(character) && answers.Contains(character))
                    {
                        answer += character;
                    }
                }
                if (answer.Length <= 1)
                {
                    Console.WriteLine("Invalid input. Checkbox questions MUST have more than one answer and answers must be A, B, C, and/or D.");
                }
            }
            return answer;
        }
    }
}

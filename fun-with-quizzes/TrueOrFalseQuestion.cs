using System;
namespace fun_with_quizzes
{
    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion()
        {
        }

        public TrueOrFalseQuestion(string questionBody, string correctAnswer)
        {
            questionBody = QuestionBody;
            correctAnswer = CorrectAnswer;
        }
    }
}

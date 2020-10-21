using System;
namespace fun_with_quizzes
{
    public abstract class Question
    {
        public string QuestionBody { get; set; }
        public string UserAnswer { get; set; }
        public string CorrectAnswer { get; set; }

        public Question()
        {           
        }

        public Question(string questionBody, string correctAnswer)
        {
            QuestionBody = questionBody;
            CorrectAnswer = correctAnswer;
        }

        public abstract string GetQuestionType();

        public abstract string PrintOptions();

        public abstract string GetAnswer();
    }
}

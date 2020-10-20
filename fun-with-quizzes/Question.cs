using System;
namespace fun_with_quizzes
{
    public abstract class Question
    {
        private readonly int id;
        private static int nextId = 1;
        public string QuestionBody { get; set; }
        public string UserAnswer { get; set; }
        public string CorrectAnswer { get; set; }

        public Question()
        {
            id = nextId;
            nextId++;
        }
    }
}

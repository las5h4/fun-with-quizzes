using System;
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

        public MultipleChoiceQuestion(string questionBody, string optionA, string optionB, string optionC, string optionD, string correctAnswer)
        {
            questionBody = QuestionBody;
            optionA = OptionA;
            optionB = OptionB;
            optionC = OptionC;
            optionD = OptionD;
            correctAnswer = CorrectAnswer;
        }
    }
}

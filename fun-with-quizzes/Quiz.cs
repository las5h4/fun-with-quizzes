using System;
using System.Collections.Generic;
using System.Linq;

namespace fun_with_quizzes
{
    public class Quiz
    {
        private static List<Question> Questions { get; set; } = new List<Question>() { };

        public static void Main(string[] args)
        {
            MultipleChoiceQuestion aMultipleChoiceQuestion = new MultipleChoiceQuestion("What language are we learning in unit 2?", "javascript", "java", "C#", "python", "C");
            TrueOrFalseQuestion aTrueOrFalseQuestion = new TrueOrFalseQuestion("C# is a fun language to learn", "TRUE");
            CheckboxQuestion aCheckboxQuestion = new CheckboxQuestion("Which of the following are types of birds?", "Housecat", "Parrot", "Cobra", "Chicken", "BD");

            Questions.Add(aMultipleChoiceQuestion);
            Questions.Add(aTrueOrFalseQuestion);
            Questions.Add(aCheckboxQuestion);

            InitialPrompt();
        }

        public Quiz()
        {
        }

        public static void InitialPrompt()
        {
            Console.WriteLine("Welcome to Logan's Quiz! What would you like to do?\n0 - Take the quiz\n1 - Add a question to the quiz");
            string input = Console.ReadLine();
            if (!input.Equals("0") && !input.Equals("1")) 
            {
                Console.WriteLine("Invalid input.");
                InitialPrompt();
            }

            if (input.Equals("0"))
            {
                RunQuiz();
            }

            if (input.Equals("1"))
            {
                AddQuestion();
            }
        }

        public static string GradeQuiz(double score, double questionNumber)
        {
            double percent = Math.Round((score / questionNumber) * 100);
            return $"**********\n**********\n\nGRADE:\n{score} out of {questionNumber}\n{percent}%\n\n**********\n**********";
        }

        public static void RunQuiz()
        {
            Console.WriteLine("**********\n**********\n\nQUIZ TIME!!!\n\n**********\n**********\n");

            double questionNumber = 0;
            double score = 0;

            foreach (Question question in Questions)
            {
                questionNumber++;
                Console.WriteLine($"{question.GetQuestionType()}\n{questionNumber}.) {question.QuestionBody}\n{question.PrintOptions()}");
                question.UserAnswer = question.GetAnswer();
                if (question.UserAnswer.ToUpper().Equals(question.CorrectAnswer.ToUpper()))
                {
                    score++;
                }
            }
            Console.WriteLine(GradeQuiz(score, questionNumber));

            InitialPrompt();
        }

        public static void AddQuestion()
        {
            Console.WriteLine("What type of question would you like to create?\n0 - Multiple Choice\n1 - True Or False\n2 - Checkbox\n3 - Short Answer\n\n4 - Cancel");
            string input = Console.ReadLine();
            string[] options = { "0", "1", "2", "3", "4" };
            if (!options.Contains(input))
            {
                Console.WriteLine("Invalid input.");
                AddQuestion();
            }
            else
            {
                if (input.Equals("4"))
                {
                    InitialPrompt();
                }

                if (input.Equals("0"))
                {
                    MultipleChoiceQuestion newMultipleChoiceQuestion = new MultipleChoiceQuestion();

                    Console.WriteLine("Please type your question:");
                    newMultipleChoiceQuestion.QuestionBody = Console.ReadLine();
                    newMultipleChoiceQuestion.AddOptions();
                    newMultipleChoiceQuestion.CorrectAnswer = newMultipleChoiceQuestion.GetAnswer();
                    Questions.Add(newMultipleChoiceQuestion);

                    InitialPrompt();
                }

                if (input.Equals("1"))
                {
                    TrueOrFalseQuestion newTrueOrFalseQuestion = new TrueOrFalseQuestion();

                    Console.WriteLine("Please type your true-or-false statement:");
                    newTrueOrFalseQuestion.QuestionBody = Console.ReadLine();
                    Console.WriteLine("What is the correct answer? Please type TRUE or FALSE:");
                    newTrueOrFalseQuestion.CorrectAnswer = newTrueOrFalseQuestion.GetAnswer();
                    Questions.Add(newTrueOrFalseQuestion);

                    InitialPrompt();
                }

                if (input.Equals("2"))
                {
                    CheckboxQuestion newCheckboxQuestion = new CheckboxQuestion();

                    Console.WriteLine("Please type your question:");
                    newCheckboxQuestion.QuestionBody = Console.ReadLine();
                    newCheckboxQuestion.AddOptions();
                    //Console.WriteLine("Please type option A:");
                    //newCheckboxQuestion.OptionA = Console.ReadLine();
                    //Console.WriteLine("Please type option B:");
                    //newCheckboxQuestion.OptionB = Console.ReadLine();
                    //Console.WriteLine("Please type option C:");
                    //newCheckboxQuestion.OptionC = Console.ReadLine();
                    //Console.WriteLine("Please type option D:");
                    //newCheckboxQuestion.OptionD = Console.ReadLine();

                    //string correctAnswer = "";
                    //while (correctAnswer.Length <= 1)
                    //{
                    //    Console.WriteLine("Please enter the letters of the correct options");
                    //    string correctAnswerInput = Console.ReadLine().ToUpper();
                    //    correctAnswer = "";
                    //    string answers = "aAbBcCdD";
                    //    foreach (char character in correctAnswerInput)
                    //    {
                    //        if (!correctAnswer.Contains(character) && answers.Contains(character))
                    //        {
                    //            correctAnswer += character;
                    //        }
                    //    }
                    //    if (correctAnswer.Length <= 1)
                    //    {
                    //        Console.WriteLine("Invalid input. Checkbox questions MUST have more than one answer and answers must be A, B, C, and/or D.");
                    //    }
                    //}


                    //maybe should be CheckboxQuestion.GetAnswer()?
                    newCheckboxQuestion.CorrectAnswer = newCheckboxQuestion.GetAnswer();
                    Questions.Add(newCheckboxQuestion);

                    InitialPrompt();
                }

                if (input.Equals("3"))
                {
                    Console.WriteLine("This functionality does not yet exist");

                    InitialPrompt();
                }
            }
        }
    }
}

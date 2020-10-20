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
            string answers = "ABCD";
            string answer = "BD";
            bool contains = answers.Contains(answer);
            Console.WriteLine(contains);

            string input = InitialPrompt();

            if (input.Equals("0"))
            {

            }

            if (input.Equals("1"))
            {
                AddQuestion();
            }
        }

        public Quiz()
        {
        }

        public static string InitialPrompt()
        {
            Console.WriteLine("Welcome to Logan's Quiz! What would you like to do?\n0 - Take the quiz\n1 - Add a question to the quiz");
            string input = Console.ReadLine();
            if (!input.Equals("0") && !input.Equals("1")) 
            {
                Console.WriteLine("Invalid input.");
                InitialPrompt();
            }
            return input;
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
                    Console.WriteLine("Please type option A:");
                    newMultipleChoiceQuestion.OptionA = Console.ReadLine();
                    Console.WriteLine("Please type option B:");
                    newMultipleChoiceQuestion.OptionB = Console.ReadLine();
                    Console.WriteLine("Please type option C:");
                    newMultipleChoiceQuestion.OptionC = Console.ReadLine();
                    Console.WriteLine("Please type option D:");
                    newMultipleChoiceQuestion.OptionD = Console.ReadLine();
                    Console.WriteLine("Please enter the letter of the correct option");
                    string correctAnswer = Console.ReadLine();
                    string[] answers = { "A", "B", "C", "D" };
                    while (!answers.Contains(correctAnswer.ToUpper()))
                    {
                        Console.WriteLine("Invalid input. Enter A, B, C, or D:");
                        correctAnswer = Console.ReadLine();
                    }
                    newMultipleChoiceQuestion.CorrectAnswer = correctAnswer;
                    Questions.Add(newMultipleChoiceQuestion);

                    InitialPrompt();
                }

                if (input.Equals("1"))
                {
                    TrueOrFalseQuestion newTrueOrFalseQuestion = new TrueOrFalseQuestion();

                    Console.WriteLine("Please type your true-or-false statement:");
                    newTrueOrFalseQuestion.QuestionBody = Console.ReadLine();
                    Console.WriteLine("What is the correct answer? Please type TRUE or FALSE:");
                    string correctAnswer = Console.ReadLine();
                    string[] answers = { "TRUE", "FALSE" };
                    while (!answers.Contains(correctAnswer.ToUpper()))
                    {
                        Console.WriteLine("Invalid input. Enter TRUE or FALSE:");
                        correctAnswer = Console.ReadLine();
                    }
                    newTrueOrFalseQuestion.CorrectAnswer = correctAnswer;
                    Questions.Add(newTrueOrFalseQuestion);

                    InitialPrompt();
                }

                if (input.Equals("2"))
                {
                    CheckboxQuestion newCheckboxQuestion = new CheckboxQuestion();

                    Console.WriteLine("Please type your question:");
                    newCheckboxQuestion.QuestionBody = Console.ReadLine();
                    Console.WriteLine("Please type option A:");
                    newCheckboxQuestion.OptionA = Console.ReadLine();
                    Console.WriteLine("Please type option B:");
                    newCheckboxQuestion.OptionB = Console.ReadLine();
                    Console.WriteLine("Please type option C:");
                    newCheckboxQuestion.OptionC = Console.ReadLine();
                    Console.WriteLine("Please type option D:");
                    newCheckboxQuestion.OptionD = Console.ReadLine();

                    string correctAnswer = "";
                    while (correctAnswer.Length <= 1)
                    {
                        Console.WriteLine("Please enter the letters of the correct options");
                        string correctAnswerInput = Console.ReadLine().ToUpper();
                        correctAnswer = "";
                        string answers = "aAbBcCdD";
                        foreach (char character in correctAnswerInput)
                        {
                            if (!correctAnswer.Contains(character) && answers.Contains(character))
                            {
                                correctAnswer += character;
                            }
                        }
                        if (correctAnswer.Length <= 1)
                        {
                            Console.WriteLine("Invalid input. Checkbox questions MUST have more than one answer and answers must be A, B, C, and/or D.");
                        }
                    }
                    newCheckboxQuestion.CorrectAnswer = correctAnswer;
                    Questions.Add(newCheckboxQuestion);

                    InitialPrompt();
                }

                
            }
        }
    }
}

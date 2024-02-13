using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class FinalExam : Exam
    {
        public FinalExam():base() 
        {
            bool isValidInput;

            questions = new List<Question>(NumberOfQuestions); 


            for (int q = 0; q < NumberOfQuestions; q++)
            {
                int QuestionType;
                Question? question;

                
                    do
                    {
                        Console.Write($"Please choose the type of Question number ({q + 1}) (1 For True and False || 2 For MCQ) :");
                    isValidInput = int.TryParse(Console.ReadLine(), out QuestionType);
                    }
                    while (!isValidInput || (QuestionType != 1 && QuestionType != 2));


                    if (QuestionType == 1)
                        question = new TFQuestion();
                    else
                        question = new MCQQuestion();

                  
             

                questions?.Add(question);

                Console.Clear();
            }
        }

        public override void ShowExam()
        {
            int myGrades = 0;
            int totalGrades = 0;
            List<string> userAnswersText = new List<string>(NumberOfQuestions);

            foreach (Question question in questions)
            {
                totalGrades += question.Mark;
                Console.WriteLine($"{question.Header}  Mark({question.Mark})");
                Console.WriteLine($"{question.Body}");

                foreach (var answer in question?.Answers)
                {
                    Console.Write($"{answer?.Id}. {answer?.AnswerText}\t\t ");
                }
                Console.WriteLine( );
                Console.WriteLine("---------------------------------");

                bool isValidInput;
                int userAnswerid;


                do { isValidInput = int.TryParse(Console.ReadLine(), out userAnswerid); }
                while (!isValidInput||(userAnswerid!=1&&userAnswerid!=2&&userAnswerid!=3));

                userAnswersText?.Add(question?.Answers?[--userAnswerid]?.AnswerText);

                if (++userAnswerid == question?.rightAnswerId)
                    myGrades += question.Mark;

                Console.WriteLine("==================================");
            }
            Console.Clear();

            Console.WriteLine("Your Answers:");

            for (int q = 0; q < NumberOfQuestions; q++)
            {
                Console.WriteLine($"Q{q+1})\t {questions[q].Body}: {userAnswersText[q]}");
            }

            Console.WriteLine($"Your exam Grade is {myGrades} From {totalGrades}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class PracticalExam : Exam
    {
        public PracticalExam()
        {
            questions = new List<Question>(NumberOfQuestions); 

            for (int q = 0; q < NumberOfQuestions; q++)
            {
                Question? question = new MCQQuestion();


                questions?.Add(question);

                Console.Clear();
            }
        }
        public override void ShowExam()
        {


            foreach (Question question in questions)
            {
                Console.WriteLine($"{question.Header}  Mark({question.Mark})");
                Console.WriteLine($"{question.Body}");

                foreach (Answer answer in question?.Answers)
                {
                    Console.Write($"{answer.Id}. {answer.AnswerText}\t\t ");
                }

                Console.WriteLine();
                Console.WriteLine("---------------------------------");

                bool isValidInput;
                int userAnswerid;


                do { isValidInput = int.TryParse(Console.ReadLine(), out userAnswerid); }
                while (!isValidInput || (userAnswerid != 1 && userAnswerid != 2 && userAnswerid != 3));






                Console.WriteLine("==================================");
            }
            Console.Clear();

            Console.WriteLine("The right answers:");


            for (int q = 0; q < NumberOfQuestions; q++)
            {
                int rightAnswer = questions[q].rightAnswerId;
                rightAnswer--;

                Console.WriteLine($"Q{q+1}) \t{questions[q].Answers[rightAnswer].AnswerText}");


            }




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Exam
    {
        public int TimeInMinutes { get; set; }
        public int NumberOfQuestions { get; set; }
        public Subject AssociatedSubject { get; set; }


        public List<Question>? questions;

        public Exam()
        {
            bool isValidInput;
            int ExamTime, ExamNumberOfQuestions;

            do
            {
                Console.Write("Please Enter the Time of the Exam in Minutes: ");
                isValidInput = int.TryParse(Console.ReadLine(), out ExamTime);
            }
            while (!isValidInput);
            TimeInMinutes = ExamTime;


            do
            {
                Console.Write("Please Enter the number of questions you want to create: ");
                isValidInput = int.TryParse(Console.ReadLine(), out ExamNumberOfQuestions);
            }
            while (!isValidInput);
            NumberOfQuestions = ExamNumberOfQuestions;
            questions = new List<Question>(NumberOfQuestions);

            Console.Clear();
        }
        public abstract void ShowExam();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Exam Exam { get; set; } 
        public Subject(int _id,string _name)
        {
            Id = _id;
            Name = _name;
        }

        public void CreateExam()
        {
            bool isValidInput;
            
            int ExamType;

            do
            {
                Console.Write("Please Enter the Type of the Exam you want to create (1 for Practical and 2 For Final): ");
                isValidInput = int.TryParse(Console.ReadLine(), out ExamType);
            }
            while (!isValidInput || (ExamType != 1 && ExamType != 2));


            if (ExamType == 1)
                Exam = new PracticalExam();
            else
                Exam = new FinalExam();


         


           



        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Question
    {
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }


        internal List<Answer> Answers=new List<Answer>();
        internal int rightAnswerId;
        public Question(string _header)
        {Console.Clear();

            Header = _header;
            Console.WriteLine(Header);

            Console.Write("Please Enter the body of the question: ");
           Body= Console.ReadLine();

            bool isValidInput;
            int _mark;
            do
            {
                Console.Write("Please Enter the mark of the question: ");
                isValidInput = int.TryParse(Console.ReadLine(), out _mark);
            }
            while (!isValidInput);

            Mark = _mark;

        }

    }
}

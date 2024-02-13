using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class TFQuestion : Question
    {
        public TFQuestion() :base ("True | False Question ")
        {

            Answer answer1 = new( 1, "True");
            Answers?.Add(answer1);


            Answer answer2 = new(2, "False");
            Answers?.Add(answer2);


            bool isValidInput;
            int rightanswer;
            do
            {
                Console.Write($"Please Enter the right answer of Question (1 For True and 2 For False): ");
                isValidInput = int.TryParse(Console.ReadLine(), out rightanswer);

            }
            while (!isValidInput || (rightanswer != 1 && rightanswer != 2 ));

            rightAnswerId = rightanswer;


        }

    }
}

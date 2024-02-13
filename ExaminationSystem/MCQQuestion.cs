using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class MCQQuestion:Question
    {
        public MCQQuestion() :base ("Choose one Answer Question")
        {

            Console.WriteLine("The Choices of Question: ");

            for (int ans = 0; ans < 3; ans++)
            {
                string? answerText;

                Console.Write($"Please Enter the Choice Number {ans+1}: ");
                answerText=Console.ReadLine();

                if (answerText != null)
                {
                    answerText = answerText.Trim();

                    Answer answer = new(ans + 1, answerText);

                    Answers?.Add(answer);

                }
                else
                {
                    Console.WriteLine("No Answer");
                }


            }

            bool isValidInput;
            int rightanswer;
            do
            {
                Console.Write($"Please Specify the right choice of Question: ");
                isValidInput=int.TryParse(Console.ReadLine(),out rightanswer);

            }
            while (!isValidInput || (rightanswer!=1&&rightanswer!=2&&rightanswer!=3));

            rightAnswerId = rightanswer;
        }

    }
}

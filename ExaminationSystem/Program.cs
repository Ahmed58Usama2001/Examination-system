using System.Diagnostics;

namespace ExaminationSystem;


class Program
{
    static void Main(string[] args)
    {

        Subject sub1 = new Subject(1,"C#");

        sub1.CreateExam();
        Console.Clear();
        Console.Write("Do you want to start the Exam (y | n): ");

        if(char.Parse(Console.ReadLine())=='y')
            {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            sub1.Exam.ShowExam();
            Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
        }



    }

}
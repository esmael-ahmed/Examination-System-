using System.Diagnostics;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject01 = new Subject(10, "c#");
            subject01.CreateExame();
            Console.Clear();
            Console.WriteLine("Do you Want To Start The Exam (y || n): ");

            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();
                subject01.exam.ShowExam();
                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
            }
            
        }
    }
}

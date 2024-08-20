using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal abstract class Exam
    {
        public int TimeOfExame { get; set; }
        public int NumbersOfQuestions { get; set; }

        public Question[] Questions;

        protected Exam(int timeOfExame, int numbersOfQuestions)
        {
            TimeOfExame = timeOfExame;
            NumbersOfQuestions = numbersOfQuestions;
            Questions = new Question[NumbersOfQuestions];
        }

        public abstract void ShowExam();

        public void DisplayQuestions()
        {
            Console.Clear();
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"{Questions[i].Header}\t\tMark({Questions[i].Mark})");
                Console.WriteLine($"{Questions[i].Body}");
                for (int j = 0; j < Questions[i].AnswersList.Length; j++)
                {
                    Console.Write($"{j + 1}. {Questions[i].AnswersList[j].AnswerText}\t\t\t");
                }
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------");
                Questions[i].UserAnswer = int.Parse(Console.ReadLine());
                Console.WriteLine("==================================================================");
            }
        }
        

    }
}

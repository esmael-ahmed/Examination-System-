using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Practical_Exam : Exam
    {
        public Practical_Exam(int timeofexam, int numberofquestions) : base(timeofexam, numberofquestions)
        {
            
        }
        public override void ShowExam()
        {
            DisplayQuestions();

            Console.Clear();
            Console.WriteLine("The Right Answers :");
            
            for (int i = 0; i < Questions.Length; i++)
            {
                
                Console.WriteLine($"Q{i + 1})\t{Questions[i].AnswersList[Questions[i].RightAnswerIndex].AnswerText}");
            }

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Final_Exam : Exam
    {
        public Final_Exam(int timeofexam, int numberofquestions) : base(timeofexam, numberofquestions)
        {  
            
        }
        public override void ShowExam()
        {
            DisplayQuestions();

            Console.Clear();
            Console.WriteLine("Your Answers:");
            int totalGrade = 0, totalMark = 0;
            for (int i = 0; i < Questions.Length; i++)
            {
                if (Questions[i].UserAnswer == (Questions[i].RightAnswerIndex + 1))
                {
                    totalGrade += Questions[i].Mark;
                }
                totalMark += Questions[i].Mark;
                Console.WriteLine($"Q{i + 1})\t{Questions[i].Body}:\t{Questions[i].AnswersList[Questions[i].UserAnswer - 1].AnswerText}");
            }

            Console.WriteLine($"Your Exam Grade Is {totalGrade} From {totalMark}");

        }
    }
}

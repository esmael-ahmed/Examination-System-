using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal abstract class Question
    {
        protected Question(string body, int mark, int rightAnswerIndex, Answer[] answersList)
        {
            Body = body;
            Mark = mark;
            RightAnswerIndex = rightAnswerIndex;
            AnswersList = answersList;
        }



        public abstract string Header { get; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public int RightAnswerIndex { get; set; }

        public int UserAnswer { get; set; }

        public Answer[] AnswersList { get; set; }


    }
}

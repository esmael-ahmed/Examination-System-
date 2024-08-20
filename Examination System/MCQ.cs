using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class MCQ : Question
    {
        
        public MCQ(string body, int mark, int rightAnswerIndex, Answer[] answersList): base (body, mark, rightAnswerIndex, answersList)
        {
            
        }

        public override string Header { get { return "Choose One Answer Question"; } }
    }
}

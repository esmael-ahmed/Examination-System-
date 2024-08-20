using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class True_Or_False : Question
    {
        public True_Or_False( string body, int mark, int rightAnswerIndex, Answer[] answersList) : base( body, mark, rightAnswerIndex, answersList)
        {
            
        }

        public override string Header { get {return"True | False Question" ;} }
    }
}

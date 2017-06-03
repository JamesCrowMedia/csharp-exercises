using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime
{
    class MultiChoice : Question {
        public MultiChoice(string question, string choices, string answer) : base(question, choices, answer) { }
    }
}

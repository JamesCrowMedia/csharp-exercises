using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime
{
    class TrueOrFalse : Question
    {
        public TrueOrFalse(string question, string choices, string answer) : base(question, choices, answer)
        {
            this.Choices = new List<string>() { "True", "False" };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime
{
    class CheckBox : Question
    { 

    public override string ReadQuestiion()
    {
        StringBuilder allChoices = new StringBuilder();

        for (int i = 0; i < this.Choices.Count(); i++)
        {
            allChoices.Append(String.Format("| {0}  ", this.Choices[i]));
        }

        return String.Format("Q: {0}\nPick all that apply(seperate with '|':\n {1}", GetQuestion, allChoices);
    }

    public CheckBox(string question, string choices, string answer) : base(question, choices, answer)
        {
            this.Choices = this.SplitToList(choices);
        }
    }
}

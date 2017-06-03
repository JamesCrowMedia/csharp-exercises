using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime
{
    abstract class Question
    {
        private string question;
        public string GetQuestion { get { return question; } set { question = value; } }

        private List<string> choices = new List<string>();
        public List<string> Choices { get { return choices; } set { choices = value; } }

        private List<string> answer = new List<string>();
        public List<string> Answer { get { return answer; } set { answer = value; } }

        public virtual string ReadQuestiion()
        {
            StringBuilder allChoices = new StringBuilder();

            for (int i=0; i < this.choices.Count(); i++)
            {
                allChoices.Append(String.Format("| {0}  ", this.choices[i]));
            }

            return String.Format("Q: {0}\nPick One: {1}", GetQuestion, allChoices);
        }

        public virtual bool IsCorrect(string input)
        {
            List<string> userAnswer = this.SplitToList(input); ;
            userAnswer.Sort();

            if (userAnswer.Count() != answer.Count())
            {
                return false;
            }

            answer.Sort();

            for (int i = 0; i < userAnswer.Count(); i++)
            {
                if (!userAnswer[i].ToLower().Equals(answer[i].ToLower()))
                {
                    return false;
                }
            }

            return true;
        }

        private List<string> SplitToList(string inputString, char splitChar = '|')
        {
            return inputString.Split(splitChar).ToList();
        }

        public Question(string question, string choices, string answer)
        {
            List<string> answerList = this.SplitToList(answer);
            List<string> choicesList = this.SplitToList(choices);
            this.question = question;
            this.choices = choicesList;
            this.answer = answerList;
        }

    }
}

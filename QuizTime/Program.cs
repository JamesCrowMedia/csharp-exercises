using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Question question1 = new TrueOrFalse("Is it true?", "", "True");
            Console.WriteLine(question1.ReadQuestiion());
            string input = Console.ReadLine();

            if (question1.IsCorrect(input))
            {
                Console.WriteLine("You got it right!");
            }
            else
            {
                Console.WriteLine("You got it wrong!");
            }

            Question question2 = new MultiChoice("Choose red.", "Red|Green|Blue", "Red");
            Console.WriteLine(question2.ReadQuestiion());
            string input2 = Console.ReadLine();

            if (question2.IsCorrect(input2))
            {
                Console.WriteLine("You got it right!");
            }
            else
            {
                Console.WriteLine("You got it wrong!");
            }

            Question question3 = new CheckBox("Choose One through Three.", "One|Two|Three|Four|Five", "One|Two|Three");
            Console.WriteLine(question3.ReadQuestiion());
            string input3 = Console.ReadLine();

            if (question3.IsCorrect(input3))
            {
                Console.WriteLine("You got it right!");
            }
            else
            {
                Console.WriteLine("You got it wrong!");
            }

            Console.ReadLine();
        }
    }
}

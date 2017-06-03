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
            TrueOrFalse question1 = new TrueOrFalse("Is it true?", "", "True");
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


            Console.ReadLine();
        }
    }
}

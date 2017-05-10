using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveLetters
{
    class Program
    {
        static void Main(string[] args)
        {// Create List
            List<string> words = new List<string>();

            // Propt user for list content, generate list
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Word {0}: ", i + 1);
                string entry = Console.ReadLine();

                words.Add(entry);
            }
            // Call and display result of IsFive method
            Console.WriteLine("The following words contain five letters:");

            foreach (string word in IsFive(words))
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }

        public static List<string> IsFive(List<string> words)
        {
            // This method takes in a list of strings and returns a list of those strings that are a length of 5.
            List<string> isFiveLetters = new List<string>();

            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    isFiveLetters.Add(word);
                }
            }

            return isFiveLetters;
        }
    }
}

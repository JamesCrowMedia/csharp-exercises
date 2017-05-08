using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine("What is your search string?");

            string user_string = Console.ReadLine();

            bool contains = alice.ToLower().Contains(user_string.ToLower());

            if (contains)
            { 
                Console.WriteLine(user_string + " is in the string!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(user_string + " is NOT in the string!");
                Console.ReadLine();
            }

        }
    }
}

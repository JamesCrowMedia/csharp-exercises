using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingChar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Load a file or hit enter: ");


            string filePath = Console.ReadLine();

            string test_string = LoadData(filePath);


            Dictionary<char, int> counter = CharCounter(test_string);
            PrintDict(counter);
            Console.ReadLine();
        }

        static Dictionary<char, int> CharCounter(string test_string)
        {
            Dictionary<char, int> counter = new Dictionary<char, int>();

            foreach(char c in test_string)
            {
                if (Char.IsLetter(c))
                { 
                    if (counter.ContainsKey(char.ToUpper(c)))
                    {
                        counter[char.ToUpper(c)] += 1;
                    }
                    else
                    {
                        counter[char.ToUpper(c)] = 1;
                    }

                }
            }

            return counter;
        }

        static void PrintDict(Dictionary<char, int> dict)
        {
            foreach(KeyValuePair<char, int> c in dict)
            {
                Console.WriteLine("{0}: {1}", c.Key, c.Value);
            }
        }



        private static string LoadData(string filePath)
        {

            string data;

            string path = @filePath;

            if (File.Exists(path))
            {
                data = File.ReadAllText(path);
                Console.WriteLine("\n******\n" + data + "\n******\n");
            }
            else
            {
                Console.WriteLine("Enter your text to count:");
                data = Console.ReadLine();
            }



            return data;
        }

    }
}

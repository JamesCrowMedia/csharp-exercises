using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEvenNum
{
    class Program
    {
        static void Main(string[] args)
        {   // Create List
            List<int> numbers = new List<int>();

            // Propt user for list content, generate list
            for (int i = 0; i < 10; i++)
            {
                bool is_digit = false;
                int entry;

                // Only take int as input, re-ask if not an int
                do
                {
                    Console.Write("Number {0}: ", i + 1);
                    is_digit = int.TryParse(Console.ReadLine(), out entry);
                } while (is_digit == false);

                numbers.Add(entry);
                
            }
            // Call and display result of SumEven method
            Console.WriteLine("The sum of the even numbers is: {0}", SumEven(numbers));
            Console.ReadLine();
        }

        public static int SumEven(List<int> list)
        {   
            // This method takes in a list and sums the even numbers only
            int sum = 0;

            foreach (int n in list)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
            }

            return sum;
        }
    }
}

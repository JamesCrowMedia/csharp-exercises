using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numberArray = new int[] { 1, 1, 2, 3, 5, 8 };

            foreach (int n in numberArray)
            {
                Console.WriteLine(n);

            }

            Console.ReadLine();
        }
    }
}

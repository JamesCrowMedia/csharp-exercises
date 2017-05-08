using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            int miles=  int.Parse(Console.ReadLine());

            Console.WriteLine("How much fuel have you used?");
            double fuel = double.Parse(Console.ReadLine());

            Console.WriteLine("MPG: " + (miles / fuel));
            Console.ReadLine();
        }
    }
}

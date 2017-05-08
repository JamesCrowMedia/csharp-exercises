using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your width? ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("What is your height? ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("The area of your rectangle is: " + (width * height));
            Console.ReadLine();
        }
    }
}

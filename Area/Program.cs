using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad;
            String rad_str;
           
            
            do
            {
                Console.Write("Enter a radius: "); 
                rad_str = Console.ReadLine();

                bool test = double.TryParse(rad_str, out rad);

                if (test)
                {
                    rad = double.Parse(rad_str);
                    double area = (3.14 * rad * rad);

                    Console.WriteLine();
                    Console.WriteLine("The radius of a circle of radius {0} is: {1}", rad, area);
                    Console.ReadLine();
                };
             } while (rad_str != "exit");
                
        }   
    }
}

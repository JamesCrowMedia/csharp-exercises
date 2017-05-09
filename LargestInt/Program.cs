using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number_array = new int[5];

            for(int i = 0; i < number_array.Length; i++)
            {
                Console.WriteLine("Number {0}: ", i + 1);
                number_array[i] = int.Parse(Console.ReadLine());
            }

            int maxVal = maxValue(number_array);

            Console.WriteLine("The largest number is: " + maxVal);
            Console.ReadLine();
        }

        public static int maxValue(int[] array)
        {

            int maxVal = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                { 
                    maxVal = array[i];
                }
            }
            return maxVal;
        }
    
    }

}

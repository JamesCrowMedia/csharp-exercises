using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddLists
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press Enter to start:");
            Console.ReadLine();

            List<int> list1 = new List<int> { 3, 4, 5, 1 };
            List<int> list2 = new List<int> { 1, 6 };

            PrintList(list1);
            PrintList(list2);
            List<int> sums = AddLists(list1, list2);
            PrintList(sums);
            Console.ReadLine();

        }

        static List<int> AddLists(List<int> list1, List<int> list2)
        {
            List<int> sums = new List<int> ();
            int loop_count = list1.Count;

            if(list1.Count < list2.Count)
            {
                loop_count = list2.Count;
            }

            for(int i = 0; i < loop_count; i++)
            {
                sums.Add(list1.ElementAtOrDefault(i) + list2.ElementAtOrDefault(i));
            }


            return sums;
        }

        static void PrintList(List<int> intList)
        {
            foreach(int i in intList)
            { 
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}

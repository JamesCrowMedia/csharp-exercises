using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradebookEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent = " ";
            int newStudentID = -1;

            do
            {
                newStudent = " ";
                newStudentID = -1;

                do
                {
                    Console.Write("Name: ");
                    newStudent = Console.ReadLine();

                    if (newStudent != "")
                    {
                        bool isInt = false;
                        do
                        {
                            Console.Write("{0}'s ID: ", newStudent);
                            isInt = int.TryParse(Console.ReadLine(), out newStudentID);

                        } while (isInt == false);

                        students.Add(newStudentID, newStudent);
                    }

                    

                } while (newStudent != "");

                

            } while (newStudent != "" && newStudentID < 0);

            StringBuilder MyStudents = new StringBuilder("Currently Enrolled Students:");

            foreach(KeyValuePair<int, string> student in students)
            {
                MyStudents.AppendFormat(String.Format("\n    ID# {0}: {1}", student.Key, student.Value));
            }

            Console.WriteLine(MyStudents);
            Console.ReadLine();

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        public class Student
        {
            private string firstName;
            private string lastName;
            public string Name
            {
                get { return string.Format("{0} {1}", firstName, lastName); }
            }
            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }
            public string LastName
            {
                get { return firstName; }
                set { lastName = value; }
            }



            private readonly int studentId;
            public int StudentId
            {
                get { return studentId; }
                //private set { studentId = value; }
            }

            private int numberOfCredits;
            public int NumberOfCredits { get { return numberOfCredits; } set { numberOfCredits = value; } }

            private double gpa;
            public double Gpa { get { return gpa; } set { gpa = value; } }


            public Student(string firstName, string lastName, int Id, int numberOfCredits=0, double gpa = 0.0)
            {
                FirstName = firstName;
                LastName = lastName;
                studentId = Id;
                NumberOfCredits = numberOfCredits;
                Gpa = gpa;

            }
        }
        public class Course
        {
            private readonly int courseId;
            public int CourseId
            {
                get { return courseId; }
            }


            private string title;
            public string Title
            {
                get { return title; }
                set { title = value; }
            }


            private List<Student> enrollment = new List<Student>();
            public List<Student> Enrollment
            {
                get { return enrollment; }
            }
            public void Enroll(Student student)
            {
                enrollment.Add(student);   
            }

        public Course (int id, string title)
            {
                courseId = id;
                Title = title;
            }

        }
        static void Main(string[] args)
        {
            Student newStudent1 = new Student("Kasey", "Oglesby", 1234);
            Student newStudent2 = new Student("James", "Crow", 2345);
            Student newStudent3 = new Student("Andy", "Russell", 3456);

            Console.WriteLine("ID# {0}: {1} - Credits: {2} - GPA: {3}", newStudent1.StudentId, newStudent1.Name, newStudent1.NumberOfCredits, newStudent1.Gpa);
            Console.WriteLine("ID# {0}: {1} - Credits: {2} - GPA: {3}", newStudent2.StudentId, newStudent2.Name, newStudent2.NumberOfCredits, newStudent2.Gpa);
            Console.WriteLine("ID# {0}: {1} - Credits: {2} - GPA: {3}", newStudent3.StudentId, newStudent3.Name, newStudent3.NumberOfCredits, newStudent3.Gpa);

            Console.ReadLine();

            Course newCourse = new Course(101, "LC101");
            newCourse.Enroll(newStudent1);
            newCourse.Enroll(newStudent2);
            newCourse.Enroll(newStudent3);

            Console.WriteLine("{0}: {1}\n**********", newCourse.CourseId, newCourse.Title);

            Console.ReadLine();

            foreach (Student student in newCourse.Enrollment)
            {
                Console.WriteLine("{0} - {1}", student.StudentId, student.Name);
            }
            Console.ReadLine();

        }
    }
}

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
            public override string ToString()
            {
                return String.Format("ID# {0}: {1} - {2} - GPA: {3}", StudentId, Name, GetGradeLevel(), Gpa);
            }

            public override bool Equals(object o)
            {
                Student s2 = o as Student;
                return StudentId == s2.StudentId;
            }

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

            public void AddGrade(int courseCredits, double grade)
            {
                double qualityPoints = gpa * numberOfCredits;
                numberOfCredits += courseCredits;
                qualityPoints += grade;
                gpa = qualityPoints / Convert.ToDouble(numberOfCredits);
            }

            public string GetGradeLevel()
            {
                if (numberOfCredits < 30) { return String.Format("Credits: {0} - Freshman", numberOfCredits); }
                else if (numberOfCredits < 60) { return String.Format("Credits: {0} - Sophmore", numberOfCredits); }
                else if (numberOfCredits < 90) { return String.Format("Credits: {0} - Junior", numberOfCredits); }
                else { return String.Format("Credits: {0} - Senior", numberOfCredits); }

            }

            public Student(string firstName, 
                            string lastName, 
                            int Id, 
                            int numberOfCredits=0, 
                            double gpa = 0.0)
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

            public override string ToString()
            {
                return String.Format("{0}: {1}", CourseId, Title);
            }

            public override bool Equals(object o)
            {
                Course c2 = o as Course;
                return CourseId == c2.CourseId;
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
            Student newStudent1 = new Student("Kasey", "Oglesby", 1234, 29, 3.9);
            Student newStudent2 = new Student("James", "Crow", 2345, 60, 3.7);
            Student newStudent3 = new Student("Andy", "Russell", 3456, 91, 3.9);

            Console.WriteLine(newStudent1.ToString());
            Console.WriteLine(newStudent2.ToString());
            Console.WriteLine(newStudent3.ToString());

            Console.ReadLine();

            newStudent1.AddGrade(3, 2.0);
            newStudent2.AddGrade(3, 4.0);
            newStudent3.AddGrade(3, 3.0);

            Console.WriteLine(newStudent1.ToString());
            Console.WriteLine(newStudent2.ToString());
            Console.WriteLine(newStudent3.ToString());

            Console.ReadLine();

            Course newCourse = new Course(101, "LC101");
            newCourse.Enroll(newStudent1);
            newCourse.Enroll(newStudent2);
            newCourse.Enroll(newStudent3);

            Console.WriteLine(newCourse.ToString());

            Console.ReadLine();

            foreach (Student student in newCourse.Enrollment)
            {
                Console.WriteLine("{0} - {1}", student.StudentId, student.Name);
            }
            Console.ReadLine();

        }
    }
}

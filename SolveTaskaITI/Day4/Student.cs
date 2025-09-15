using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day4
{
    public class Student : Person
    {
        public List<Course> EnrolledCourses { get; set; }
        public List<Grade> Grades { get; set; }

        public Student(string name, int age) : base(name, age)
        {
            EnrolledCourses = new List<Course>();
            Grades = new List<Grade>();
        }

        public void RegisterCourse(Course course)
        {
            EnrolledCourses.Add(course);

            switch (course.Level)
            {
                case CourseLevel.Beginner:
                    Console.WriteLine("Good luck starting out!");
                    break;
                case CourseLevel.Intermediate:
                    Console.WriteLine("Keep going, you’re making progress!");
                    break;
                case CourseLevel.Advanced:
                    Console.WriteLine("This will be challenging!");
                    break;
            }
        }

        public Grade GetTotalGrade()
        {
            Grade total = new Grade { value = 0 };
            foreach (var grade in Grades)
            {
                total += grade;
            }
            return total;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I am {Name}, {Age} years old, and I am a Student.");
        }

    }
}

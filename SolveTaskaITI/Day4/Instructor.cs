using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day4
{
    public class Instructor : Person
    {
        public List<Course> CoursesTaught { get; set; } = new List<Course>();
        public Instructor(string name , int age) : base(name,age){}

        public void TeachCourse(Course course)
        {
            CoursesTaught.Add(course);
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hello, I am {Name}, {Age} years old, and I am an Instructor.");
        }
    }
}

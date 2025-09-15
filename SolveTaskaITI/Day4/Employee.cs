using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day4
{
    public class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void AssignCourse(Course course)
        {
            Courses.Add(course);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day4
{
    public class Company
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }

        public Company(string name)
        {
            Name = name;
            Departments = new List<Department>();
        }

        public void GenerateReport()
        {
            Console.WriteLine("\n========== Company Report ==========\n");

            foreach (var dept in Departments)
            {
                Console.WriteLine($"Department: {dept.Name}, Employees: {dept.Employees.Count}");

                foreach (var emp in dept.Employees)
                {
                    if (emp is Student student)
                    {
                        Console.WriteLine($"  Student: {student.Name}");
                        foreach (var c in student.EnrolledCourses)
                            Console.WriteLine($"    Enrolled in: {c.Title} (Instructor: {c.Instructor?.Name})");

                        Console.WriteLine($"    Total Grades: {student.GetTotalGrade().value}");
                    }
                    else if (emp is Instructor instructor)
                    {
                        Console.WriteLine($"  Instructor: {instructor.Name}");
                        foreach (var c in instructor.CoursesTaught)
                            Console.WriteLine($"    Teaching: {c.Title}");
                    }
                }
            }
        }
    }
}

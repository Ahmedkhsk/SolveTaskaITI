using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day4
{
    public static class Day4
    {
        public static void Shape()
        {
                List<Shape> shapes = new List<Shape>
                {
                    new Circle(5),
                    new Rectangle(4, 6)
                };
                foreach (var shape in shapes)
                {
                    shape.Draw();
                    Console.WriteLine($"Area: {shape.Area()}");
                }
        }
        public static void RunSystem()
        {
            Company company = new Company("Tech Solutions");

            Department itDept = new Department("IT");
            Department hrDept = new Department("HR");

            company.Departments.Add(itDept);
            company.Departments.Add(hrDept);

            Student student1 = new Student("Alice", 20);
            Student student2 = new Student("Bob", 22);
            Instructor instructor1 = new Instructor("Dr. Smith", 45);
            Instructor instructor2 = new Instructor("Prof. Johnson", 50);

            itDept.Employees.Add(student1);
            itDept.Employees.Add(instructor1);
            hrDept.Employees.Add(student2);
            hrDept.Employees.Add(instructor2);

            Course course1 = new Course("C# Basics", CourseLevel.Beginner);
            Course course2 = new Course("Advanced C#", CourseLevel.Advanced);
            Course course3 = new Course("HR Management", CourseLevel.Intermediate);

            instructor1.TeachCourse(course1);
            instructor1.TeachCourse(course2);
            instructor2.TeachCourse(course3);

            student1.RegisterCourse(course1);
            student1.RegisterCourse(course2);
            student2.RegisterCourse(course3);

            course1.Instructor = instructor1;
            course2.Instructor = instructor1;
            course3.Instructor = instructor2;

            student1.Grades.Add(new Grade { value = 85 });
            student1.Grades.Add(new Grade { value = 90 });
            student2.Grades.Add(new Grade { value = 88 });

            company.GenerateReport();

        }
    }
}

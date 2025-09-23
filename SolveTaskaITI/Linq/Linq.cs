using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Linq
{
    public static class Linq
    {
        public static void LinqDemo()
        {
            List<int> numbers = new List<int> { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            
            //Query1
            var query1_numbers = numbers.Distinct().OrderBy(n => n);
            Console.WriteLine("Query1 - Distinct and Sorted:");
            foreach (var num in query1_numbers)
                Console.Write(num + " ");

            //Query2
            var query2_numbers = query1_numbers.Select(n => new { Number = n, Multiplication = n * n });
            Console.WriteLine("\n\nQuery2 - Number and its Square:");
            foreach (var item in query2_numbers)
                Console.WriteLine($"Number: {item.Number}, Multiplication: {item.Multiplication}");
            
            //________________________
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            //Query1
            var query1_names = names.Where(n => n.Length > 3);
            Console.WriteLine("\nQuery1 - Names longer than 3 characters:");
            foreach (var isLong in query1_names)
                Console.WriteLine(isLong);

            //Query2
            var query2_names = names.Where(n => n.ToLower().Contains('a'));
            Console.WriteLine("\nQuery2 - Names containing 'a':");
            foreach (var hasA in query2_names)
                Console.WriteLine(hasA);

            //Query3
            var query3_names = names.Take(2);
            Console.WriteLine("\nQuery3 - First two names:");
            foreach (var firstTwo in query3_names)
                Console.WriteLine(firstTwo);

            //________________________
            List<Student> students = new List<Student>()
            {
                new Student()
                { 
                  ID=1, FirstName="Ali", LastName="Mohammed",
                  Subjcets = new Subjcet[]
                  {
                      new Subjcet(){ Code=22,Name="EF"}, new ()
                      {
                         Code=33,Name="UML"
                      }
                  }
                },
                new Student()
                { 
                    ID=2, FirstName="Mona", LastName="Gala",
                    Subjcets = new Subjcet []
                    { 
                        new Subjcet()
                        {
                            Code=22,Name="EF"
                        
                        }, 
                        new Subjcet ()
                        { 
                            Code=34,Name="XML"                   
                        }
                        ,new Subjcet ()
                        { 
                            Code=25, Name="JS"
                        }
                    }
                }, 
                new
                Student()
                { 
                    ID=3, FirstName="Yara", LastName="Yousf", 
                    Subjcets = 
                    new Subjcet[]
                    { 
                        new Subjcet ()
                        {
                            Code=22,Name="EF"
                        }, new Subjcet (){
                            Code=25,Name="JS"
                        }
                    }
                },
                new Student()
                { 
                    ID=1, FirstName="Ali", LastName="Ali",
                    Subjcets = new Subjcet []
                    { 
                        new Subjcet ()
                        { 
                            Code=33,Name="UML"
                        }
                    }
                },
            };

            //Query1
            var query1_students = students.Select
            (
                s => new 
                {
                    FullName = s.FirstName + ' ' + s.LastName,
                    SubjectCount = s.Subjcets.Length
                }
            );

            Console.WriteLine("\nQuery1 - Students' Full Names and Subject Counts:");
            foreach (var student in query1_students)
                Console.WriteLine($"FullName: {student.FullName}, SubjectCount: {student.SubjectCount}");

            //Query2
            var query2_students = students.
                OrderByDescending(s => s.FirstName)
                .ThenBy(s=>s.LastName)
                .Select(s => new {s.FirstName , s.LastName});

            Console.WriteLine("\nQuery2 - Students sorted by First and Last Names:");
            foreach (var student in query2_students)
                Console.WriteLine($"FirstName: {student.FirstName}, LastName: {student.LastName}");

            //Query3
            var query3_students = students
                .SelectMany
                 (
                    s => s.Subjcets,
                    
                    (student,subjcet) => new 
                    {
                        StudentName = student.FirstName + ' ' + student.LastName,
                        SubjectName = subjcet.Name
                    }
                 );
            Console.WriteLine("\nQuery3 - Students and their Subjects:");
            foreach (var item in query3_students)
                Console.WriteLine($"StudentName: {item.StudentName}, SubjectName: {item.SubjectName}");

            //Query Bouns
            var query = students
            .SelectMany(
                s => s.Subjcets,
                (student, subject) => new { StudentName = student.FirstName + " " + student.LastName, SubjectName = subject.Name }
            )
            .GroupBy(x => x.SubjectName)
            .Select(g => new
            {
                Subject = g.Key,
                StudentsCount = g.Select(x => x.StudentName).Distinct().Count(),
                Students = g.Select(x => x.StudentName).Distinct()
            });
            
            Console.WriteLine("\nBonus Query - Subjects with Student Counts and Names:");
            foreach (var item in query)
            {
                Console.WriteLine($"Subject: {item.Subject}, StudentsCount: {item.StudentsCount}");
                foreach (var student in item.Students)
                {
                    Console.WriteLine($" - {student}");
                }
            }


        }

    }
}

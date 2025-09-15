using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day4
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Id = IdGenerator.GetNextId();
            Name = name;
            Age = age;
        }
        public abstract void Introduce();
    }
}

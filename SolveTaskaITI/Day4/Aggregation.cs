namespace SolveTaskaITI.Day4
{
    class Employee1
    {
        public string Name { get; set; } = default!;
        public int Age { get; set; }

    }
    class Department1
    {
        public string Name { get; set; } = default!;
        public List<Employee1> Employees { get; set; } = new List<Employee1>();
    }

    class Company1
    {
        public string Name { get; set; } = default!;
        public List<Department1> Departments { get; set; } = new List<Department1>();

    }
}

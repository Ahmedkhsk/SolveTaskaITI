using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day4
{
    public enum CourseLevel
    {
        Beginner,
        Intermediate,
        Advanced
    }
    public class Course
    {
        public string Title { get; set; } = default!;
        public CourseLevel Level { get; set; }
        public Instructor Instructor { get; set; }
        public Course(string title , CourseLevel level)
        {
            Title = title;
            Level = level;
            Instructor = default!;
        }
    }
}

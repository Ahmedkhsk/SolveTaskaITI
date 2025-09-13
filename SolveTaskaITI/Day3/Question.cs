using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day3
{
    public class Question
    {
        public string Header { get; set; } = default!;
        public string Body { get; set; } = default!;
        public int Mark { get; set; } = default!;

        public Question(){}

        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public virtual string Show()
        {
            return $"Header: {Header}\nBody: {Body}\nMark: {Mark}\n";
        }
    }
}

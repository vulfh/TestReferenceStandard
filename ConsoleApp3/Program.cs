using StandardLogMessageFormatter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var logFormatter = new StandardLogMessageFormatter.Formatter();
            Console.WriteLine(logFormatter.FormatDebug("Hello from .Net Standard"));
        }
    }
}

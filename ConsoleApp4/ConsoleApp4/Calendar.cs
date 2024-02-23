using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Calendar: IPrinter
    {
        DateTime date = DateTime.Today;
        public void Print() 
        { 
            Console.WriteLine(date.ToString("dddd"));
        }
    }
}

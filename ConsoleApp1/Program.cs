using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine(AddNumbers());
        }

        public static string AddNumbers()
        {
            return $"1+2={1 + 2}";
        }
    }
}

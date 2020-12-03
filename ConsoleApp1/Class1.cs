using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        public static int AddNumbers(string input1, string input2)
        {
            int.TryParse(input1, out int number1);
            int.TryParse(input2, out int number2);

            return number1 + number2;
        }
    }
}

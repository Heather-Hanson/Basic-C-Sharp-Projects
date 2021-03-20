using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            math.Add(10,7);
            math.Add(num1: 13, num2: 9);

            Console.ReadLine();
        }
    }
}

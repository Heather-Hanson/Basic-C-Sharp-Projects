using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public class Math
    {
        // Method with an output integer
        public void Divide(int num1, out int num2)
        {
            num2 = 2;
            int quotient = num1 / num2;
            Console.WriteLine("{0} divided by {1} equals {2}.", num1, num2, quotient);
        }

        //Method with output parameters
        public void Add(out int num1, out int num2)
        {
            num1 = 5;
            num2 = 4;
            int sum = num1 + num2;
            Console.WriteLine("{0} plus {1} equals {2}", num1, num2, sum);
        }
        // Overload Method
        public static int Add(int num1, int num2)
        {
            return num1 + num2; ;

        }

    }
}

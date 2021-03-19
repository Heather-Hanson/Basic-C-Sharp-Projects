using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment
{
    public class Math
    {
        // First create a method that takes in an integer, performs math, returns result as an integer.
        public static int Multiply(int num)
        {
            int product = num * 22;
            return product;
        }
        // Create a second method that takes in a decimal, performs math, returns result as an integer
        public static int Multiply(decimal num)
        {
            int product = Convert.ToInt32(num) * 5;
            return product;
        }
        // Create a third method that takes in a string, performs math (if it can) and returns result as an integer
        public static int Multiply(string num)
        {
            int product = Convert.ToInt32(num) * 2;
            return product;
        }
    }
}

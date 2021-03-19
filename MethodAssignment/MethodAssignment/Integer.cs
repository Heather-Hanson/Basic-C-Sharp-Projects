using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    // create my class "Integer", make it public
    public class Integer
    {
        // Method 1 = sum, it is static so that it can return a value, public so I can use it elsewheare and its paramters are data type integer
        public static int Sum(int num1) 
        {
            // create variable for return value
            int total;
            // create equation passing result to my new variable
            total = num1 + 6;
            // return value of my variable
            return total;
        }
        // Method 2 uses modifier to get a remainder
        public static int Modifier(int num1)
        {
            int total;
            total = num1 % 6;
            return total;
        }
        // Method 3 gets the product
        public static int Product(int num1)
        {
            int total;
            total = num1 * 6;
            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Heather";
            //string quote = "The man said, \\\"Hello\", Heather. \n Hello on a new line. \t Hello on a tab.";
            //string fileName = "C:\\Users\\Heather"; 
            //OR
            //string fileName2 = @"C:\Users\Heather";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(name);

            //string name = "Heather";
            //name = "Jean";

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Heather");

            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}

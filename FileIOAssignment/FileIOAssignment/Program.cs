using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\Users\Heather\source\repos\Heather-Hanson\Basic-C-Sharp-Projects\log.txt", true))
            {
                file.WriteLine(num);
            }
            string text = File.ReadAllText(@"C:\Users\Heather\source\repos\Heather-Hanson\Basic-C-Sharp-Projects\log.txt");
            Console.WriteLine("My log reads the number you entered was: {0}", text);
            Console.ReadLine();
        }
    }
}



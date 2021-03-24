using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date and time is: {0}", DateTime.Now);
            Console.WriteLine("Please enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            TimeSpan addition = new TimeSpan(num, 0, 0);
            Console.WriteLine("It will be exactly {0:hh:mm} in {1} hours from now.", DateTime.Now.Add(addition), num);

            Console.Read();
        }
    }
}

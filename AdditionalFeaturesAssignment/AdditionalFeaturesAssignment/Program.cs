using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = ("Heather Hanson");
            var age = 38;

            Person person1 = new Person(name, age);
            Console.WriteLine("My constant is: {0} and my var is: {1}", person1.Name, person1.Age);

            Person person2 = new Person(name);
            Console.Write("This is a demonstration of my constructor chain.  My Name (which was passed): {0}, and my age (which was not): {1}", person2.Name, person2.Age);

            Console.ReadLine();

        }
    }
}



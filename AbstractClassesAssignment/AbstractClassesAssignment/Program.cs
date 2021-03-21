using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism used to create object of type IQuittable
            IQuittable quittable = new Employee()
            {
                FirstName = "Heather", 
                LastName = "Hanson" 
            };

            // Call the Quit Method
            quittable.Quit();

            //// Instantiate Employee object
            //Employee employee = new Employee();
            //// Create values for properties
            //employee.FirstName = "Heather";
            //employee.LastName = "Hanson";
            ////Call SayName method
            //employee.SayName();

            Console.ReadLine();
        }
    }
}

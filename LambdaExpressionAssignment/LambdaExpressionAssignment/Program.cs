using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list of 10 employees
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Heather", "Hanson", 1));
            employees.Add(new Employee("Joe", "Kelly", 2));
            employees.Add(new Employee("Joe", "MacKinnon", 3));
            employees.Add(new Employee("Erin", "Roach", 4));
            employees.Add(new Employee("Laurie", "MacKinnon", 5));
            employees.Add(new Employee("Rhonda", "Hanson", 6));
            employees.Add(new Employee("Lindsay", "Hollohan", 7));
            employees.Add(new Employee("Stephen", "Hindelang", 8));
            employees.Add(new Employee("Daniel", "Parlee", 9));
            employees.Add(new Employee("Terry", "Hollohan", 10));

            // Create new list of employees named Joe
            foreach(Employee employee in employees)
            {
                if(employee.FirstName == "Joe")
                {
                    List<Employee> joe1 = new List<Employee>();
                    joe1.Add(employee);

                    foreach (Employee joe0 in joe1)
                    {
                        Console.WriteLine(joe0.FirstName + " " + joe0.LastName + " " + joe0.Id);

                    }
                }
            }

            // Create new list of employees named Joe, but using Lambda

            List<Employee> joe2 = employees.Where(n => n.FirstName == "Joe").ToList();
            Console.WriteLine("\nThere are {0} employees named Joe. They are: ", joe2.Count);

            foreach (Employee joe in joe2)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);

            }


            // Create new list of employee Ids less than 5
            List<Employee> ids = employees.Where(n => n.Id > 5).ToList();
            Console.WriteLine("\nThere are {0} employee Ids that are greater than 5.  They are: ", ids.Count);
            foreach (Employee id in ids)
            {
                Console.WriteLine(id.FirstName + " " + id.LastName + " " + id.Id);

            }

            Console.ReadLine();
        }
    }
}


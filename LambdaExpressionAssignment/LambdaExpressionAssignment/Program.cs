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
                    Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
                }
            }

            // Create new list of employees named Joe, but using Lambda
            foreach (Employee employee in employees.Where(n => n.FirstName == "Joe"))
            { 
                 List<Employee> joe2 = new List<Employee>();
                 Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);              
            }

            // Create new list of employee Ids less than 5
            foreach(Employee employee in employees.Where(n => n.Id > 5))
            {
                List<Employee> ids = new List<Employee>();
                Console.WriteLine(employee.Id);
            }

            Console.ReadLine();
        }
    }
}

//List<int> numberList = new List<int>(){1,2,3, 21, 42};
// int sum = numberList.Where(x => x > 20).Sum();
// Console.WriteLine(sum);
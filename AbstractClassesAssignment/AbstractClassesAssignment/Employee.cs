using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignment
{
    public class Employee : Person, IQuittable // Employee inherits abstract class Person and interface IQuittable
    {
       //Implement SayName abstract method
        public override void SayName()
        {
             Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

        // Implement Quit interface method
        public void Quit()
        {
            Console.WriteLine("I, {0} {1}, QUIT!", FirstName, LastName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignment
{
    public class Employee : Person // Employee inherits abstract class Person
    {
       //Implement SayName abstract method
        public override void SayName()
        {
             Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}

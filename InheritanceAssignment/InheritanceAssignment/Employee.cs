using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Employee : Person // Employee class will inherit from Person class.
    {
        public int Id { get; set; }


        // Overload the == operator requires me to overload the != operator for balance
        public static bool operator ==(Employee employee1, Employee employee2)
        {
                return employee1.Id == employee2.Id;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1 != employee2;
        }
        // I override the Equals() method and GetHashCod method (for balance)
        public override bool Equals(Object obj)
        {
            return Equals(obj as Employee);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}


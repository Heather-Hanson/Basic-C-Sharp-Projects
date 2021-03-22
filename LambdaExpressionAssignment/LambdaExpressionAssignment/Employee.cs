using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    public class Employee : Person
    {

        public int Id { get; set; }

        // create a constructor for employee list
        public Employee(string FirstName, string LastName, int Id)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Id = Id;
        }
    }

}

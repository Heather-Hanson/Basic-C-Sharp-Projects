using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    public class Employee<T> : Person // Generic type paramater accepted
    {
        public int Id { get; set; }
        public List<T> Things { get; set; } // property with generic list

    }
}

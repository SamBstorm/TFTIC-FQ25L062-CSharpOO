using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_26_Generic_01.Models
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

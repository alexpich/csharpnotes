using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes__Basics
{
    // this class is a blueprint for a datatype
    class Human
    {
        // member variable
        public string firstName;
        public string lastName;

        // Constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // member
        public void IntroduceYourself()
        {
            Console.WriteLine("Hello, I'm {0} {1}", firstName, lastName);
        }
    }
}

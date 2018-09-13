using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Person
    {
        public Person(string firstName, string middleName, string lastName)
        {
            
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;

        }

        public Person(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName; 
        }

        public Person()
        {
            
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string GetFullName()
        {
            string fullname = FirstName + " " + MiddleName + " " + LastName;
            return fullname;

        }
    }
}

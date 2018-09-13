using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Liakot";
            person1.MiddleName = "Ali";
            person1.LastName = "Fokir";
            string fullName = person1.GetFullName();
            Person person2=new Person();
            Console.WriteLine(fullName);
            Console.ReadKey();
        }
    }
}

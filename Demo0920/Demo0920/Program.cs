using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo0920
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p;
            p = new Customer();
            p.FirstName = "Kalle";

            Customer c;
            c = (Customer)p; //(Customer) spells out that you implicitly want it. This gives c 4 properties.
            //Refers to p.FirstName, c = p
            c.CustomerID = 100;
            c.FirstName = "Arne";
            c.LastName = "Anka";
            Console.WriteLine(p.FirstName);

            Console.WriteLine(p.FullName); //This requires either a function, a method or a
            // property called Fullname. The easiest would be a property but is exchangable with a method
            Console.WriteLine();

            Employee emp; //Re-uses p to turn Arne Anka intpo Musse Pigg
            p = new Employee();
            p.FirstName = "Musse";
            p.LastName = "Pigg";

            emp = (Employee)p;
            Console.WriteLine(emp.FullName);
            Console.WriteLine(p.FullName);
            Console.WriteLine(c.FullName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo0920
{
    public class Customer : Person //":" is the symbol for inheritence
    {
        public int CustomerID { get; set; }
        public bool VIP { get; set; }
    }

    public class Employee : Person
    {
        public int salary { get; set; }
        public int MyProperty { get; set; }
    }

    public abstract class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        //This Method is read-only. Also remember that creating a property comes to task before creating a method.
        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }
    }
}

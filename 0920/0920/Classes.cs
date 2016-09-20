using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0920
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public int Phone { get; set; }
    }

    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
        public int Salary { get; set; }
    }

    class Supplier
    {
        public string Contact { get; set; }
        public string Company { get; set; }
        public int Phone { get; set; }
    }
}

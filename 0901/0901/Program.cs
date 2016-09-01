using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0901
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("::AXCEL.INC NAME-MESSER-UPPER:: BOOTING UP...");
            Console.WriteLine("What is your first name?");
            string name1 = Console.ReadLine();

            Console.WriteLine("Good. What is your last name?");
            string name2 = Console.ReadLine();

            string fullname = name1 + " " + name2;


        }
    }
}

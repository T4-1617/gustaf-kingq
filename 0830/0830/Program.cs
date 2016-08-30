using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0830
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Good day, sir/ma'am. What is your first name?");
            Console.WriteLine("");
            string n1 = Console.ReadLine();
            System.Console.Write("Noted. Your first name is " + n1 + ".");
            System.Console.Write("Next and final question: What is your last name?");
            Console.WriteLine("");
            string n2 = Console.ReadLine();
            Console.Write("Welcome aboard, Mr. or Miss " + n2 + "!");
            Console.ReadLine();
        }
    }
}

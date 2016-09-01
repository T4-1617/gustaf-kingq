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

            string name1_upper = name1.ToUpper();

            string name2_upper = name2.ToUpper();


            string fullname = name1 + " " + name2;

            Console.WriteLine("Number of chars + space in " + fullname + " is: " + fullname.Length);

            int chars_no_space = fullname.Length - 1;


            Console.WriteLine("Number of chars without space in " + fullname + " is: " + chars_no_space);

            Console.WriteLine("Your first name is " + name1.ToUpper([0]) + " and has: " + name1.Length + " chars.");

            Console.WriteLine("Your first name is " + name2.ToUpper([0]) + " and has: " + name2.Length + " chars.");


            Console.WriteLine("In the opposite order, in a more business fashion, your name looks like this: " + name2 + " " + name1);


            Console.WriteLine("You name vertically printed looks like: ");
            for (int i = 0; i < name1_upper.Length; i++)
            {
                
                Console.Write("----->");
                Console.WriteLine(name1_upper[i]);
            }

            for (int i = 0; i < name2_upper.Length; i++)
            {

                Console.Write("------->");
                Console.WriteLine(name2_upper[i]);
            }


        }
    }
}

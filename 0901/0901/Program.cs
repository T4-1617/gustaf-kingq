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
            //1
            Console.WriteLine("::AXCEL.INC NAME-MESSER-UPPER:: BOOTING UP...");
            Console.WriteLine("What is your first name?");
            string name1 = Console.ReadLine();

            Console.WriteLine("Good. What is your last name?");
            string name2 = Console.ReadLine();
            string name1_normal = name1.ToUpper()[0] + name1.Substring(1);
            string name2_normal = name2.ToUpper()[0] + name2.Substring(1);
            string fullname = name1_normal + " " + name2_normal;


            //2.1 - 
            Console.WriteLine("Number of chars with space in " + fullname + " is: " + fullname.Length);


            //2.2 - 
            int chars_no_space = fullname.Length - 1;
            Console.WriteLine("Number of chars without space in " + fullname.Trim() + " is: " + chars_no_space);


            //2.3 - 
            Console.WriteLine("Your first name is " + name1_normal + " and has: " + name1.Length + " chars."); 


            //2.4 - 
            Console.WriteLine("Your first name is " + name2_normal + " and has: " + name2.Length + " chars.");


            //2.5 - 
            Console.WriteLine("In the opposite order, in a more business fashion, your name looks like this: " + name2_normal + " " + name1_normal);


            //2.6 - 
            Console.WriteLine("You name vertically printed looks like: ");
            for (int i = 0; i < name1.Length; i++)
            {

                Console.Write("----->");
                Console.WriteLine(name1.ToUpper()[i]);
            }

            for (int i = 0; i < name2.Length; i++)
            {

                Console.Write("------->");
                Console.WriteLine(name2.ToUpper()[i]);
            }


            //2.7 - 
        }
            public static void Reverse(string name1)
        {
            char[] cArray = name1.ToCharArray();
            string name1_reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                name1_reverse += cArray[i];
            }

            Console.WriteLine("Your name with lower letters looks like: " + name1_reverse);
        }


    }
}
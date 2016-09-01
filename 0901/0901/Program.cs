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
            //1 - Asks and recieves your first and last name. Before they get put together into a new string 
            //    their first letter get capitalized and the rest get lowered.
            Console.WriteLine("::AXCEL.INC NAME-MESSER-UPPER:: BOOTING UP...");
            Console.WriteLine("What is your first name?");
            string name1 = Console.ReadLine();

            Console.WriteLine("Good. What is your last name?");
            string name2 = Console.ReadLine();
            string name1_normal = name1.ToUpper()[0] + name1.Substring(1);
            string name2_normal = name2.ToUpper()[0] + name2.Substring(1);
            string fullname = name1_normal + " " + name2_normal;


            //2.1 - Counts and explains the number of chars in the full name including the space in between.
            Console.WriteLine("Number of chars with space in " + fullname + " is: " + fullname.Length);
            Console.WriteLine("");

            //2.2 - Same as above but without the space.
            int chars_no_space = fullname.Length - 1;
            Console.WriteLine("Number of chars without space in " + fullname.Trim() + " is: " + chars_no_space);
            Console.WriteLine("");

            //2.3 - Same as 2.1 but solely the first name. The name gets returned with the number of it's chars.
            Console.WriteLine("Your first name is " + name1_normal + " and has: " + name1.Length + " chars.");
            Console.WriteLine("");

            //2.4 - Same as 2.1 but solely the last name. The name gets returned with the number of it's chars.
            Console.WriteLine("Your first name is " + name2_normal + " and has: " + name2.Length + " chars.");
            Console.WriteLine("");

            //2.5 - The full name gets returned but with the opposite order, the first name comes after the last.
            Console.WriteLine("In the opposite order, in a more business fashion, your name looks like this: ");
            Console.WriteLine(":: :: " + name2_normal + " " + name1_normal);
            Console.WriteLine("");


            //2.6 - The full name is returned capitalized vertically with the padding of a five shafted arrow 
            //      for the first name and a seven shafted arrow for the last name. 
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
            Console.WriteLine("");


            //2.7 - Returns a reversed full name with lower cased letters.
            string fullname_out = "";
            for (int i = fullname.Length - 1; i >= 0; i--)
            {
                fullname_out += fullname[i];
            }
            Console.WriteLine("Your name lower cased and reverse looks like: " );
            Console.WriteLine(":: :: " + fullname_out.ToLower());
            Console.WriteLine("");


            //2.8 - A function that capitalizes the first letter of both names, then lowers the next and 
            //      follows that order starting anew when it goes from the first name to the last. It keeps order 
            //      by checking if the current index value is dividable with two.
            string name1_mixed = "";
            for (int i = 0; i < name1.Length; i++)
            {
                if (i % 2 != 0)
                {
                    name1_mixed += name1.ToLower()[i];
                }
                else
                    name1_mixed += name1.ToUpper()[i];
            }
            string name2_mixed = "";
            for (int i = 0; i < name2.Length; i++)
            {
                if (i % 2 != 0)
                {
                    name2_mixed += name2.ToLower()[i];
                }
                else
                    name2_mixed += name2.ToUpper()[i];
            }
            Console.WriteLine("Your name in mixed casing (but with a capital letter each time) looks like: ");
            Console.WriteLine(":: :: " + name1_mixed + " " + name2_mixed);
            Console.WriteLine("");


            //2.9 - Creates eight new string values, four for each name, and 'censurs' the name four times, each
            //      time shaping another letter until the name is converted into basic 'leetspeech' before
            //      returning the final string value of both names in a WriteLine.
            string name1_leet1 = name1_normal.Replace('a', '4');
            string name1_leet2 = name1_leet1.Replace('e', '3');
            string name1_leet3 = name1_leet2.Replace('i', '1');
            string name1_leet4 = name1_leet3.Replace('t', '7');

            string name2_leet1 = name2_normal.Replace('a', '4');
            string name2_leet2 = name2_leet1.Replace('e', '3');
            string name2_leet3 = name2_leet2.Replace('i', '1');
            string name2_leet4 = name2_leet3.Replace('t', '7');
            Console.WriteLine("Your name turned into 'leetspeech' looks like: ");
            Console.WriteLine(":: :: " + name1_leet4 + " " + name2_leet4);
            Console.WriteLine("");
        }

        }
    }





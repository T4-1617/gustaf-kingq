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
            System.Console.Write("Since there weren't any said prohibition on the length of the greeting segment of this code I am not only writing it in English instead of Swedish but also doing it longer than necessary. Oh yeah, what is your first name?");
            Console.WriteLine("");
            string n1 = Console.ReadLine();
            System.Console.Write("Well isn't that a name. " + n1 + ". What's your last name then? This other question is ending this whole English-longer-than-necessary-bit and we'll go back to Swedish after I'v recieved your answer.");
            Console.WriteLine("");
            string n2 = Console.ReadLine();
            Console.Write("Hej " + n2 + "!");
            Console.ReadLine();
        }
    }
}

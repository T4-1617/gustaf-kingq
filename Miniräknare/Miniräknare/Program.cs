using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Miniräknare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.Beep();

            string s;
            s = Console.ReadLine();

            int i;
            i = Int32.Parse(s);
            Console.WriteLine(s);

        }
    }
}

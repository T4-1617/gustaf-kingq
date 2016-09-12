using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo0912
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Color = "Röd";
            Console.WriteLine("Bilens färg är " + c.Color);
            Car d;
            d = c;
            d.Color = "Blå";
            Console.WriteLine("Bilens färg är " + c.Color);
            Console.WriteLine("Bilens färg är " + d.Color);

            int i = 10;
            int j;
            j = i;
            j = 20;
            Console.WriteLine("i = " + i + " och j= " + j);
        }
    }

    public class Car
    {
        public string RegistrationNumber{ get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0831_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(":::AXCEL.INC CALCULATOR BOOTING UP:: : . . ."); //Egen touch
            Console.WriteLine("");
            System.Console.Write("Please input desired calculation:"); //Den frågar och tar emot det första talet
            System.Console.WriteLine("What is the first number? ");
            string input1 = Console.ReadLine();

            System.Console.WriteLine("Good. What is the second number? "); //Den frågar och tar emot det andra talet
            string input2 = Console.ReadLine();

            int i1; //Omvandlar båda talen från formatet string till integers
            i1 = Int32.Parse(input1);
            int i2;
            i2 = Int32.Parse(input2);

            System.Console.WriteLine("Which is the desired math method?"); //Frågar efter hur du vill kalkylera de två talen
            System.Console.WriteLine("Enter 1 for +");
            System.Console.WriteLine("Enter 2 for -");
            System.Console.WriteLine("Enter 3 for *");
            System.Console.WriteLine("Enter 4 for /");

            int method = Convert.ToInt32(Console.ReadLine()); //Påbörjar en switch och ger en räknemetod beroende på siffran given vid det tidigare steget
            switch (method)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Result:");
                    Console.Write(i1 + " + " + i2 + " = "); //Returnerar hela uträkningen
                    Console.Write(i1 + i2);
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Result:");
                    Console.Write(i1 + " - " + i2 + " = ");
                    Console.Write(i1 - i2);
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Result:");
                    Console.Write(i1 + " * " + i2 + " = ");
                    Console.Write(i1 * i2);
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Result:");
                    Console.Write(i1 + " / " + i2 + " = ");
                    Console.Write(i1 / i2);
                    break;
            }
            Console.ReadKey(true);

        }
        }
    }


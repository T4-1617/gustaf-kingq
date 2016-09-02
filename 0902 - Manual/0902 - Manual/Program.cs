using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0902___Manual
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] GameMap = new bool[8, 6];

            //Fyll spelplanen med startvärden, dvs false = inga båtar
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    GameMap[x, y] = false;
                }
            }
            //Introduktion
            Console.WriteLine("::AXCEL.INC BATTELSHIP.SIM:: BOOTING UP...");
            Console.WriteLine("Get ready to sink some ships!");

            //Frågar efter kordinater för de första tre skeppen
            int Boats = 0;
            Console.WriteLine("Enter your x location for your first ship, limited to 0-7.");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your y location for your first ship, limited to 0-5:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            GameMap[x1, y1] = true;
            Boats++;

            Console.WriteLine("Enter your x location for your second ship, limited to 0-7:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your y location for your second ship, limited to 0-5:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            GameMap[x2, y2] = true;
            Boats++;

            Console.WriteLine("Enter your x location for your third ship, limited to 0-7:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your y location for your third ship, limited to 0-5:");
            int y3 = Convert.ToInt32(Console.ReadLine());
            GameMap[x3, y3] = true;
            Boats++;

            //Frågar om man vill ha fler skepp
            Console.WriteLine("Do you seek more ships?");
            Console.WriteLine("Enter 1 if you're good to go, 2 if your want 4 ships or 3 if you want 5 ships:");
            int method = Convert.ToInt32(Console.ReadLine());
            switch (method)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter your x location for your fourth ship, limited to 0-7:");
                        int x4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter your y location for your fourth ship, limited to 0-5:");
                        int y4 = Convert.ToInt32(Console.ReadLine());
                        GameMap[x4, y4] = true;
                        Boats++;
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter your x location for your fourth ship, limited to 0-7:");
                        int x4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter your y location for your fourth ship, limited to 0-5:");
                        int y4 = Convert.ToInt32(Console.ReadLine());
                        GameMap[x4, y4] = true;
                        Boats++;

                        Console.WriteLine("Enter your x location for your fourth ship, limited to 0-7:");
                        int x5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter your y location for your fourth ship, limited to 0-5:");
                        int y5 = Convert.ToInt32(Console.ReadLine());
                        GameMap[x4, y4] = true;
                        Boats++;
                        break;
                    }
            }

            //Vi testar att skriva ut hela spelplanen
            for (int y = 0; y-1 < 5; y++)
            {
                for (int x = 0; x-1 < 7; x++)
                {
                    string p;
                    if (GameMap[x, y] == true)
                    {
                        p = " X ";
                    }
                    else
                    {
                        p = " O ";
                    }
                    //Console.Write(GameMap[x, y]); 
                    Console.Write(p);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Random r = new Random();
            int Counter = 0;
            int Rounds = 5;
          
            while (Boats != 0)
                {
                    //Frågar vart du vill skjuta
                    Console.WriteLine("Enter your x location where you wish to shoot, limited to 0-7:");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter your y location where you wish to shoot, limited to 0-5:");
                    int y = Convert.ToInt32(Console.ReadLine());

                    if (GameMap[x, y] == true)
                    {
                        Rounds--;
                        Console.WriteLine("Shot's fired! It's a... ");
                        Console.WriteLine("Hit! At {0},{1}!", x, y);
                        Counter++;
                        GameMap[x, y] = false;
                        Boats--;
                        Console.WriteLine(":: Shots left: " + Rounds);
                        Console.WriteLine(":: Boats sunk: " + Counter);
                        Console.WriteLine(":: Boats left: " + Boats);
                        Console.WriteLine();
                    if (Rounds == 0)
                    {
                        break;
                    }
                }
                    else
                    {
                        Rounds--;
                        Console.WriteLine("Shot's fired! It's a... ");
                        Console.WriteLine("Miss at {0},{1}... no luck.", x, y);
                        Console.WriteLine(":: Shots left: " + Rounds);
                        Console.WriteLine(":: Boats sunk: " + Counter);
                        Console.WriteLine(":: Boats left: " + Boats);
                        Console.WriteLine();
                    if (Rounds == 0)
                    {
                        break;
                    }
                    }
            }

            //Nu är det dags för ett avgörande meddelande, den säger till om du vann eller inte
            if (Boats == 0)
            {
                Console.WriteLine("All the battleships have been sunk!");
                Console.WriteLine(":: YOU WIN! ::");
            }
            else
            {
                Console.WriteLine("Ammunition depleted. You ran out of rounds!");
                Console.WriteLine(":: GAME OVER ::");
            }
        }
    }
}

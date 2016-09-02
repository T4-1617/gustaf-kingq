using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0902
{
    class Program
    {
        static void Main(string[] args)
        {
            //The game field posing 7x5 wide and long
            bool[,] GameMap = new bool[7, 5];

            //Fills the field with non-occupant spaces so that no ship is spawned when the game field is spawned
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    GameMap[x, y] = false;
                }
            }
            //Introduction
            Console.WriteLine("::AXCEL.INC BATTELSHIP.SIM:: BOOTING UP...");
            Console.WriteLine("Get ready to sink some ships!");

            //Makes up the locations a ship could spawn, up to five different locations
            Random r1 = new Random();

            int rx1 = r1.Next(0, 7);
            int ry1 = r1.Next(0, 5);
            int rx2 = r1.Next(0, 7);
            int ry2 = r1.Next(0, 5);
            int rx3 = r1.Next(0, 7);
            int ry3 = r1.Next(0, 5);
            int rx4 = r1.Next(0, 7);
            int ry4 = r1.Next(0, 5);
            int rx5 = r1.Next(0, 7);
            int ry5 = r1.Next(0, 5);

            int Boats = 0;

            //Selects three of said locations as occupant by a ship and adds three to the Boat counter
            GameMap[rx1, ry1] = true;
            Boats++;
            GameMap[rx2, ry2] = true;
            Boats++;
            GameMap[rx3, ry3] = true;
            Boats++;

            //Prints 1-2 additional ships depending on the outcome of the first ship's y-axis
            if (ry1 > 2)
            {
                GameMap[rx4, ry4] = true;
                Boats++;
                if (ry1 > 4)
                {
                    GameMap[rx5, ry5] = true;
                    Boats++;
                }
            }
            //We have the game field but now it gets printed into the form of X's and O's where the X's represent an occupant space, for visual ease
            //EDIT: Replaced the X's and O's with £'s and ~'s for realism and to blur the line of reality and fantasy
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    string p;
                    if (GameMap[x, y] == true)
                    {
                        p = " £ ";
                    }
                    else
                    {
                        p = " ~ ";
                    }
                    Console.Write(p);
                }
                Console.WriteLine();
            }
            //Commencing the launch of the players shot
            Random r = new Random();
            int Counter = 0;
            int Rounds = 10;

            while (Boats != 0)
            {
                //Asks the player for coordinates for where he wishes to fire
                Console.WriteLine("Enter your x location where you wish to shoot, limited to 0-6:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your y location where you wish to shoot, limited to 0-4:");
                int y = Convert.ToInt32(Console.ReadLine());

                if (GameMap[x, y] == true)
                {
                    Rounds--; //Attempts to fire at the target
                    Console.WriteLine("Shot's fired! It's a... ");
                    Console.WriteLine("Hit! At {0},{1}!", x, y);
                    Counter++;
                    GameMap[x, y] = false;
                    Boats--;
                    //Returns all important and worth-knowing stats
                    Console.WriteLine(":: Shots left: " + Rounds);
                    Console.WriteLine(":: Boats sunk: " + Counter);
                    Console.WriteLine(":: Boats left: " + Boats);
                    Console.WriteLine();
                    //The game is over when the player is out of ammunition no matter the remaining amount of boats
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

            //Now it's time for the deciding reply that announces whether you won or not
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


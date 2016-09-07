using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0907
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prior to the last assignment, we'll need a set of
            //the three basic variables: colors, groups and amount 
            //of cards
            //Those variables needs to be doubled since we're
            //simulating two decks
            const int suits = 8;
            const int ranks = 26;
            const int amountOfCards = 104;

            Random randomizer = new Random();
            int x = randomizer.Next(0, suits);
            int y = randomizer.Next(0, ranks);

            string[,] Deck_of_String = new String[suits, ranks];
            bool[,] Deck_of_Boolean = new bool[suits, ranks];

            //The variable for the point system
            int points = 0;

            if (points == 21)
            {
                Console.WriteLine("You won, son! Returning all your points... ");
                points = 0;
                
            }
            else
            {
                if (points > 21)
                {
                    Console.WriteLine("You bust! Returning all your points... ");
                    points = 0;
                }
                else
                {
                    Console.WriteLine("Would you like another card? ");
                    Console.WriteLine("Type 1 for Yes");
                    Console.WriteLine("Type 2 for No");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    switch (answer)
                    {
                        case 1:
                            Console.WriteLine("You are dealt a: ");

                        case 2:
                            Console.WriteLine("You accumulated; " + points + " points that round.");
                            points = 0;
                    }
                        


                    if (amountOfCards = 0)
                    {
                        Console.WriteLine("You, sir, have run completely out of cards. GAME OVER.");
                        break;
                    }
                    else { }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0905_0906
{
    class Program
    {
        const int suits = 4;
        const int ranks = 13;
        const int amountOfCards = 52;
        static string[,] Deck_of_Spring = new String[suits, ranks];
        static bool[,] Deck_of_Boolean = new bool[suits, ranks];
        static string[,] initializer(string[,] Deck_of_Spring)
        {
            int check1 = 1;
            string randomSuit = string.Empty;
            for (int x = 0; x < suits; x++)
            {
                for (int y = 1; y - 1 < ranks; y++)
                {
                    switch (check1)
                    {
                        case 1:
                            randomSuit = "Hearts";
                            break;
                        case 2:
                            randomSuit = "Diamonds";
                            break;
                        case 3:
                            randomSuit = "Spades";
                            break;
                        case 4:
                            randomSuit = "Clubs";
                            break;
                        default:
                            randomSuit = "Error with string tempColourHolder!";
                            break;
                    }
                    switch (y)
                    {
                        case 1:
                            Deck_of_Spring[x, y - 1] = randomSuit + " " + "Ace";
                            break;
                        case 11:
                            Deck_of_Spring[x, y - 1] = randomSuit + " " + "Jack";
                            break;
                        case 12:
                            Deck_of_Spring[x, y - 1] = randomSuit + " " + "Queen";
                            break;
                        case 13:
                            Deck_of_Spring[x, y - 1] = randomSuit + " " + "King";
                            break;
                        default:
                            Deck_of_Spring[x, y - 1] = randomSuit + " " + y.ToString();
                            break;
                    }
                }
                check1++;
            }
            return Deck_of_Spring;
        }
        static bool check3(int x, int y)
        {
            bool check4 = false;

            if (Deck_of_Boolean[x, y] == true)
            {
                check4 = true;
            }

            return check4;
        }
        static string cardRandomizer()
        {
            Random randomizer = new Random();
            int x = randomizer.Next(0, suits);
            int y = randomizer.Next(0, ranks);
            if (check3(x, y) == true)
            {
                return cardRandomizer();
            }
            int points = 0;
            points += (y + 1);
            Deck_of_Boolean[x, y] = true;
            return Deck_of_Spring[x, y];
        }

        static void Main(string[] args)
        {
            initializer(Deck_of_Spring);
            int points = 1;
            for (int i = 1; i <= amountOfCards; i++)
            {
                Console.WriteLine("Tap enter to recieve another card.");
                Console.ReadLine();
                Console.WriteLine("Amount of placed cards(s): " + points);
                Console.WriteLine("The type of dealt card: " + cardRandomizer());
                Console.WriteLine("Amount of cards left: " + (amountOfCards - points));
                Console.WriteLine("Earned points: " + points + cardRandomizer());
                points++;
            }
        }
    }
}



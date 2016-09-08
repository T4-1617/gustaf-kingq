using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0908
{
    class Program
    {
        //Prior to the last assignment, we'll need a set of
        //the three basic variables: colors, groups and amount 
        //of cards
        //Those variables needs to be doubled since we're
        //simulating two decks
        const int suits = 16;
        const int ranks = 13;
        //Since we want the game to be over when the deck is depleted, it can't be constant
        static int amountOfCards = 208;
        static int score = 0;
        static int comScore = 0;
        static int total = 0;

        //Creates a variable for checking...

        static int check1 = 0; //Checks if the randomSuit switch outputs an error. If that's the case, a card
                               //won't be dealt

        static string[,] Deck_of_String = new String[suits, ranks];
        static bool[,] Deck_of_Boolean = new bool[suits, ranks];


        static string[,] initializer(string[,] Deck_of_String)
        {
            int check2 = 1; //A check that decides the randomSuit for loop below
            string randomSuit = string.Empty;
            for (int x = 0; x < suits; x++)
            {
                for (int y = 0; y < ranks; y++)
                {
                    switch (check2)
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
                        case 5:
                            randomSuit = "Hearts";
                            break;
                        case 6:
                            randomSuit = "Diamonds";
                            break;
                        case 7:
                            randomSuit = "Spades";
                            break;
                        case 8:
                            randomSuit = "Clubs";
                            break;
                        case 9:
                            randomSuit = "Hearts";
                            break;
                        case 10:
                            randomSuit = "Diamonds";
                            break;
                        case 11:
                            randomSuit = "Spades";
                            break;
                        case 12:
                            randomSuit = "Clubs";
                            break;
                        case 13:
                            randomSuit = "Hearts";
                            break;
                        case 14:
                            randomSuit = "Diamonds";
                            break;
                        case 15:
                            randomSuit = "Spades";
                            break;
                        case 16:
                            randomSuit = "Clubs";
                            break;
                        default:
                            randomSuit = "There wasn't any randomSuit outputted...";
                            break;
                    }
                    switch (y)
                    {
                        //Reduced string space compared to the earlier deck code
                        case 1:
                            Deck_of_String[x, y] = randomSuit + " Ace";
                            break;

                        case 11:
                            Deck_of_String[x, y] = randomSuit + " Jack";
                            break;

                        case 12:
                            Deck_of_String[x, y] = randomSuit + " Queen";
                            break;

                        case 13:
                            Deck_of_String[x, y] = randomSuit + " King";
                            break;

                        default:
                            Deck_of_String[x, y] = randomSuit + " " + y.ToString();
                            break;
                    }

                }
                check2++;
            }
            return Deck_of_String;
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
            int x = randomizer.Next(1, suits);
            int y = randomizer.Next(1, ranks);

            if (check3(x, y) == true)
            {
                return cardRandomizer();
            }
            score += y;
            Deck_of_Boolean[x, y] = true;
            return Deck_of_String[x, y];

            bool all_x_and_y = Deck_of_Boolean[suits,ranks];


        }
        //A complete and utter duplicate of the cardRandomizer that instead of increasing the player's score,
        //it increases the computer's/dealer's
        static string cardRandomizer2()
        {
            Random randomizer2 = new Random();
            int x2 = randomizer2.Next(1, suits);
            int y2 = randomizer2.Next(1, ranks);

            if (check3(x2, y2) == true)
            {
                return cardRandomizer();
            }
            comScore += y2;
            Deck_of_Boolean[x2, y2] = true;
            return Deck_of_String[x2, y2];

            bool all_x_and_y = Deck_of_Boolean[suits, ranks];


        }

        static void Main(string[] args)
        {

            initializer(Deck_of_String);
            string computersChoice = cardRandomizer();
            if (amountOfCards > 0)
            {
                amountOfCards -= 1;
                Console.WriteLine("BEEP-BOOP. I-HAVE-DRAWN-THE-CARD-" + cardRandomizer2().ToUpper());
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.WriteLine();
                Console.ReadLine();
                Console.WriteLine("Would you like a card? (Yes/No)");
                string answer = Console.ReadLine();
                switch (answer.ToLower())
                { 
                    case "yes":
                            amountOfCards -= 1;
                            Console.WriteLine("There are " + amountOfCards + " cards left in the deck.");
                            Console.WriteLine("You are dealt a: " + cardRandomizer());
                            Console.WriteLine("You have currently cards worth of " + score + " score.");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to continue...");
                            Console.WriteLine();
                            Console.ReadLine();

                    case "no":
                        Console.WriteLine("You accumilated; " + score + " score that round.");






                        score = 0;
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.WriteLine();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("That is not Yes or No. Please enter a valid input.");
                        Console.WriteLine();

                        break;
                }

                if (score == 21)
                {

                    Console.WriteLine("You won, son! Returning all your score... ");
                    score = 0;
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.WriteLine();
                    Console.ReadLine();
                }
                else
                {
                    if (score > 21)
                    {
                        Console.WriteLine("You bust! Returning all your score... ");
                        score = 0;
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.WriteLine();
                        Console.ReadLine();
                    }
                    else
                    {
                       
                        }
                    }

            }
            else
            {
                amountOfCards += 208;
                bool all_x_and_y = Deck_of_Boolean[suits, ranks];
                all_x_and_y = false;
            }
        }
    }
}

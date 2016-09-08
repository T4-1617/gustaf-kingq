using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0907
{
    class Program
    {
            //Prior to the last assignment, we'll need a set of
            //the three basic variables: colors, groups and amount 
            //of cards
            //Those variables needs to be doubled since we're
            //simulating two decks
            const int suits = 8;
            const int ranks = 13;
            //Since we want the game to be over when the deck is depleted, it can't be constant
            static int amountOfCards = 104;
            static Double points = 0;

            //Creates a variable for checking...
            static int check1 = 1; //A check that decides the randomSuit for loop below
            static int check2 = 0; //Checks if the randomSuit switch outputs an error. If that's the case, a card
            //won't be dealt

            static string[,] Deck_of_String = new String[suits, ranks];
            static bool[,] Deck_of_Boolean = new bool[suits, ranks];
            static string randomSuit = string.Empty;

            static string[,] initializer(string[,] Deck_of_String)
            {
                for (int x = 0; x < suits; x++)
                {
                    for (int y = 0; y < ranks; y++)
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

                            default:
                                check2 = 1;
                                randomSuit = "There wasn't any randomSuit outputted...";
                                break;

                        }
                        switch (y)
                        {
                            //Reduced string space compared to the earlier deck code
                            case 1:
                                Deck_of_String[x, y - 1] = randomSuit + " Ace";
                                break;

                            case 11:
                                Deck_of_String[x, y - 1] = randomSuit + " Jack";
                                break;

                            case 12:
                                Deck_of_String[x, y - 1] = randomSuit + " Queen";
                                break;

                            case 13:
                                Deck_of_String[x, y - 1] = randomSuit + " King";
                                break;

                            default:
                                Deck_of_String[x, y] = randomSuit + " " + y.ToString();
                                break;
                        }

                    }
                    check1++;
                }
                return Deck_of_String;
            }
        public bool check3(int x, int y)
        {
            bool check4 = false;

            if (Deck_of_Boolean[x, y] == true)
            {
                check4 = true;
            }

            return check4;
        }

            public string cardRandomizer()
        {
            Random randomizer = new Random();
            int x = randomizer.Next(0, suits);
            int y = randomizer.Next(0, ranks);

            if (check3(x, y) == true)
            {
                return cardRandomizer();
            }
            points += (y + 1);
            Deck_of_Boolean[x, y] = true;
            return Deck_of_String[x, y];

 
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < amountOfCards;)
            {
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
                        Console.WriteLine("Would you like a card? (Yes/No)");
                        string answer = Console.ReadLine();
                        switch (answer.ToLower())
                        {
                            case "yes":
                                if (check2 == 1)
                                {
                                    Console.WriteLine("A card has not been dealt.");
                                    check2 = 0;
                                    break;
                                }
                                else
                                {
                                    amountOfCards -= 1;
                                    Console.WriteLine("There are " + amountOfCards + " cards left in the deck.");
                                    Console.WriteLine("You are dealt a: " + randomSuit);
                                    Console.WriteLine("You have currently cards worth of " + points + " points.");
                                    break;
                                }

                            case "no":
                                Console.WriteLine("You accumilated; " + points + " points that round.");
                                points = 0;
                                break;

                            default:
                                Console.WriteLine("That is not Yes or No. Please enter a valid input.");

                                break;

                        }
                    }
                }
            }

            Console.WriteLine("You, sir, have run completely out of cards. GAME OVER.");
        }
        }
     }

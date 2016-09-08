using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0905_0906
{
    class Program
    {
            //We are going to create a deck of cards, shuffle them, give
            //input for additional cards and generally play around with
            //how the output message will behave

            //First above all else should be the three basic variables:
            //the colors of the cards, the groups and the amount of cards
            const int colors = 4;
            const int groups = 13;
            const int amountOfCards = 52;

            //Up next is the main two arrays, one string containing colors
            //and groups and a boolean that records if the card has already
            //been played or not
            static string[,] StringDeck = new String[colors, groups];
            static bool[,] BoolDeck = new bool[colors, groups];

            //Initializing the string array is essential
            static string[,] initializer(string[,] StringDeck)
        {
            //Now we need a proper variable for the choosing of the colors
            //For now, the four are represented by 1-4 in the order
            //Hearts, Diamonds, Spades and Clubs
            int colorChooser = 1;

            //To ease the task, let's make an associate variable for
            //colorChooser to hold any values
            //It should be created empty
            string colorChooser2 = string.Empty;

            //Here begins the loop
            //As a first, it loops once for every color overall, which would 
            //mean four times, having x represent the amount of used colors
            for (int x = 0; x < colors; x++)
            {
                //While it loops it also subloops once for every group that 
                //remains, meaning thirteen times four times, having y
                //represent the amount of used groups
                for (int y = 1; y - 1 < groups; y++)
                {
                    switch (colorChooser)
                    {
                        //Based on the colorChooser variable, the switch will
                        //conclude which color that should be used
                        case 1:
                            colorChooser2 = "Hearts";
                            break;
                        case 2:
                            colorChooser2 = "Diamonds";
                            break;
                        case 3:
                            colorChooser2 = "Spades";
                            break;
                        case 4:
                            colorChooser2 = "Clubs";
                            break;
                        default:
                            colorChooser2 = "Error with string tempColourHolder!";
                            break;
                    }
                    //Checks for Ace, Jack, Queen & King and names there after, else just give the y number as name
                    //Takes y - 1 so we don't try to write outside the array
                    switch (y)
                    {
                        case 1:
                            StringDeck[x, y - 1] = colorChooser2 + " " + "Ace";
                            break;
                        case 11:
                            StringDeck[x, y - 1] = colorChooser2 + " " + "Jack";
                            break;
                        case 12:
                            StringDeck[x, y - 1] = colorChooser2 + " " + "Queen";
                            break;
                        case 13:
                            StringDeck[x, y - 1] = colorChooser2 + " " + "King";
                            break;
                        default:
                            //Assign value to array, whitespace used for seperating colour & type
                            StringDeck[x, y - 1] = colorChooser2 + " " + y.ToString();
                            break;
                    }
                    //End of inner-loop
                }
                //Ups the chooser counter one tick
                colorChooser++;
            }

            //Returns the spring array
            return StringDeck;
        }
        //Function for checking if a card has been placed
        static bool cardStatus(int x, int y)
        {
            bool cardStatus2 = false;

            if (BoolDeck[x, y] == true)
            {
                cardStatus2 = true;
            }

            return cardStatus2;
        }
        //Function, using the new x and y, a randomizer variable and a counter t
        static string card_randomizer()
        {
            //Sets up both a randomizer variable but also a new x and y
            //since they weren't properly declared before
            Random randomizer = new Random();
            int x = randomizer.Next(0, colors);
            int y = randomizer.Next(0, groups);

            //Return used so it updates actual value in original function
            if (cardStatus(x, y) == true)
            {
                return card_randomizer();
            }
            int counter = 0;
            //Ups the newly added variable one tick
            counter += (y + 1);
            //Gives the output card the status "true" so it won't be dealt again
            BoolDeck[x, y] = true;
            return StringDeck[x, y];
        }

        static void Main(string[] args)
        {
            initializer(StringDeck);
            int counter = 1;
            //The closing loop that returns writelines about it's desired input,
            //how many card's placed, how many that's left and the users
            //accumilated points 
            for (int i = 1; i <= amountOfCards; i++)
            {
                Console.WriteLine("Tap enter to recieve another card.");
                Console.ReadLine();

                //Summarized as:
                //counter = Placed cards
                //card_randomizer = The kind of placed card (color and group)
                //amountofCards-counter= How many cards that's left
                Console.WriteLine("Amount of placed cards(s): " + counter);
                Console.WriteLine("The type of dealt card: " + card_randomizer());
                Console.WriteLine("Amount of cards left: " + (amountOfCards - counter));
                Console.WriteLine("Earned points: " + counter);

                //Ups the counter a tick
                counter++;
            }
        }
    }
}



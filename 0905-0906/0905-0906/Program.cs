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
                    }

                }
                //Ups the chooser counter one tick
                colorChooser++;

            }
            //Returns the spring array
            return StringDeck;
        }
    }
}




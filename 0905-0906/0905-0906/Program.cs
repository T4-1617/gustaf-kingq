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

            //

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
            static string[,] cardDeckInit(string[,] StringDeck)
        {
            //Now we need a proper variable for the choosing of the colors
            //For now, the four are represented by 1-4 in the order
            //Hearts, Diamonds, Spades and Clubs
            int colorChooser = 1;

            //To ease the task, let's make an associate variable for
            //colorChooser to hold any values
            //It should be created empty
            string colorChooser2 = string.Empty;


        }


    }
    }


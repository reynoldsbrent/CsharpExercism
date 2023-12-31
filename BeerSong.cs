using System;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < takeDown; i++)
        {
            string currentBottle;
            string nextBottle;
            string takeBottles;

            if (startBottles == 0)
            {
                currentBottle = "No more bottles";
                nextBottle = "99 bottles";
                takeBottles = "Go to the store and buy some more";
            }
            else if (startBottles == 1)
            {
                currentBottle = "1 bottle";
                nextBottle = "no more bottles";
                takeBottles = "Take it down and pass it around";
            }
            else
            {
                currentBottle = $"{startBottles} bottles";
                nextBottle = $"{startBottles - 1} bottle{(startBottles - 1 == 1 ? "" : "s")}";
                takeBottles = "Take one down and pass it around";
            }

            if (result.Length > 0)
            {
                result.Append("\n\n");
            }

            result.Append($"{currentBottle} of beer on the wall, {currentBottle.ToLower()} of beer.\n" +
                           $"{takeBottles}, {nextBottle} of beer on the wall.");

            startBottles--;
        }

        return result.ToString();
    }
}
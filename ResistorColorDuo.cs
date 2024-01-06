using System;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        int[] numbers = new int[colors.Length];
        int result;

        for (int i = 0; i < colors.Length; i++)
        {

            if (colors[i] == "black")
            {
                numbers[i] = 0;
            }
            else if (colors[i] == "brown")
            {
                numbers[i] = 1;
            }
            else if (colors[i] == "red")
            {
                numbers[i] = 2;
            }
            else if (colors[i] == "orange")
            {
                numbers[i] = 3;
            }
            else if (colors[i] == "yellow")
            {
                numbers[i] = 4;
            }
            else if (colors[i] == "green")
            {
                numbers[i] = 5;
            }
            else if (colors[i] == "blue")
            {
                numbers[i] = 6;
            }
            else if (colors[i] == "violet")
            {
                numbers[i] = 7;
            }
            else if (colors[i] == "grey")
            {
                numbers[i] = 8;
            }
            else
            {
                numbers[i] = 9;
            }
        }
        if (numbers.Length > 1)
        {
            result = Convert.ToInt32("" + numbers[0] + numbers[1]);
            return result;
        }
        else
        {
            return numbers[0];
        }
    }
}

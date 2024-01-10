using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{

    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> multiplesList = new List<int>();
        int sum = 0;

        int count = multiples.Count(); // Calculate the count once

        for (int i = 0; i < count; i++)
        {
            int currentMultiple = multiples.ElementAt(i);

            if (currentMultiple != 0)
            {
                for (int j = currentMultiple; j < max; j += currentMultiple)
                {
                    multiplesList.Add(j);
                }
            }
        }

        List<int> noDuplicates = multiplesList.Distinct().ToList();

        return noDuplicates.Sum();
    }
}
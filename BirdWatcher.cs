using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeek = {0, 2, 5, 3, 7, 8, 4};
        return lastWeek;
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int day in birdsPerDay) {
            if(day == 0) {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int totalNumberOfBirds = 0;
        for (int i = 0; i < numberOfDays; i++) {
            totalNumberOfBirds += birdsPerDay[i];
        }
        return totalNumberOfBirds;
    }

    public int BusyDays()
    {
        int numberOfBusyDays = 0;
        foreach (int day in birdsPerDay) {
            if(day >= 5) {
                numberOfBusyDays += 1;
            }
        }
        return numberOfBusyDays;
    }
}

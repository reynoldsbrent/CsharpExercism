using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        //throw new NotImplementedException("You need to implement this function.");

        if((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)){
            return true;
        } else{
        return false;
        }
    }
}
using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if(balance < 0) {
            return 3.213F;
        } else if(balance < 1000 && balance >= 0) {
            return 0.5F;
        } else if(balance >= 1000 && balance < 5000) {
            return 1.621F;
        } else {
            return 2.475F;
        }
    }

    public static decimal Interest(decimal balance)
    {
        return ((decimal) InterestRate(balance) / 100) * balance;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while(balance < targetBalance){
            balance = balance + Interest(balance);
            years++;
        }
        return years;
    }
}
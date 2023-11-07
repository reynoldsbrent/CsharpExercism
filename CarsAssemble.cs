using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");

        if(speed <= 4 && speed != 0) {
            return 1.0;
        }
        else if(speed <= 8 && speed >= 5) {
            return 0.9; 
        }
        else if(speed == 9) {
            return 0.8;
        } 
        else if(speed == 10) {
            return 0.77;
        }
        else {
        return 0;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");

        double productionRatePerHour = SuccessRate(speed) * speed * 221;

        return productionRatePerHour;
        
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");

        int workingItemsPerMinute = (int) ProductionRatePerHour(speed) / 60;

        return workingItemsPerMinute;
    }
}

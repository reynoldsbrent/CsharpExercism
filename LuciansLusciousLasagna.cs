class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int actualMinutesInOven) {
        return ExpectedMinutesInOven() - actualMinutesInOven;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers) {
        int preperationTime = numberOfLayers * 2;
        return preperationTime;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int numberOfMinutesCookingInOven) {
        int numberOfMinutes = (numberOfLayers * 2) + numberOfMinutesCookingInOven;
        return numberOfMinutes;
    }
}
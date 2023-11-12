using System;

class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int distance;
    private int battery = 100;
    
    public RemoteControlCar(int speed, int batteryDrain) {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if(battery < batteryDrain) {
            return true;
        } else {
            return false;
        }
        
    }

    public int DistanceDriven()
    {
        return distance;
    }

    public void Drive()
    {
        if(!BatteryDrained()){
            distance += speed;
            battery -= batteryDrain; 
        } 
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }

}

class RaceTrack
{
    private int distance;
    
    public RaceTrack(int distance) {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
         while (!car.BatteryDrained())
        {
            car.Drive();
        }
        return car.DistanceDriven() >= distance;
    }
}

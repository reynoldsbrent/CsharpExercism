using System;

class RemoteControlCar
{

    private int distance = 0;
    private int battery = 100;
    
    public static RemoteControlCar Buy()
    {
        //throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        //throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
        return $"Driven {distance} meters";
        
    }

    public string BatteryDisplay()
    {
        //throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
        if(this.battery > 0){
            return $"Battery at {battery}%";
        }
        else{
            return "Battery empty";
        }
        
    }

    public void Drive()
    {
        //throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
        if (this.battery > 0)
        {
            this.distance += 20;
            this.battery -= 1;
        }
        
    }
}

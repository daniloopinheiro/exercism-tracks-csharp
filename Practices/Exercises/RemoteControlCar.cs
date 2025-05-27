namespace Practices.Exercises;

public class RemoteControlCar
{
    private int _distance = 0;
    private int _batteryPercentage = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distance} meters";
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
    }

    public string BatteryDisplay()
    {
        return _batteryPercentage > 0 
            ? $"Battery at {_batteryPercentage}%"
            : "Battery empty";
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
    }

    public void Drive()
    {
        if (_batteryPercentage > 0)
        {
            _distance += 20;
            _batteryPercentage -= 1;
        }
        throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
    }
}
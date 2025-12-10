public class Running : Activity
{
    
private double _distance;

public Running (DateOnly date, string type, int time, double distance) : base(date, type, time)
    {
        _distance = distance;

    }


    public override double GetSpeed()
    {
        
        return GetDistance() / GetTime() * 60;


    }


    public override double GetPace()
    {
        
        return GetTime() / GetDistance();



    }



    
}
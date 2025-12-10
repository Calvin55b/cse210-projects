public class Cycling : Activity
{
    
private double _speed;

public Cycling (DateOnly date, string type, int time, double speed) : base(date, type, time)
    {
        
        _speed = speed;
        
    }

    




public override double GetSpeed()
    {
        
        return _speed;


    }


public override double GetPace()
    {
        
        return 60.0 / GetSpeed();



    }

    public override double GetDistance()
    {
        return GetSpeed() * GetTime()/ 60;
    }






}
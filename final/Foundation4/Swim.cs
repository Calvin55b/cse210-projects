public class Swim : Activity
{
    private int _laps;
    


public Swim (DateOnly date, string type, int time,int laps) : base(date, type, time, 0)
    {
        _laps = laps;

    }



    public override double GetDistance()
    {
        return GetLapDistance();
    }
public double GetLapDistance()
    {
        
        return _laps * 50.0 / 1000.0;


    }


public override double GetSpeed()
    {
        
        return GetLapDistance() / GetTime() * 60;


    }


public override double GetPace()
    {
        
        return GetTime() / GetLapDistance();



    }







}
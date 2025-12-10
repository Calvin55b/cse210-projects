public class Activity
{


private DateOnly _date;

private int _time;


private double _distance;


private string _type;


// private double _speed;

// private double _pace;


public Activity(DateOnly date, string type, int time, double distance)
    {
        
        _date = date;

        _type = type;

        _time = time;

        _distance = distance;

       


    }



public void SetTimeAndDistance(int time, double distance)
    {
        
        _time = time;

        _distance = distance;




    }

public int GetTime()
    {
        

        return _time;
    }


public virtual double GetDistance()
    {
        
        return _distance ;
    }


public virtual double GetSpeed()
    {
        
        return _distance / _time * 60;


    }


public virtual double GetPace()
    {
        
        return _time / _distance;



    }




  public virtual string GetSummary()
    {
        
        return $"{_date} {_type} ({_time} min)- Distance: {GetDistance():F2} km, Speed:{GetSpeed():F2} kph, Pace:{GetPace():F2} min per km\n";

    }


    public void Display()
    {
        
        Console.WriteLine($"Workout Summary:\n");
        
        Console.WriteLine($"{GetSummary()}");



    }




}
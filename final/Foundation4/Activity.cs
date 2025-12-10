public class Activity
{


private DateOnly _date;
//Time is the duration of the activity in min
private int _time;


//private double _distance;


private string _type;


// private double _speed;

// private double _pace;


public Activity(DateOnly date, string type, int time)
    {
        
        _date = date;

        _type = type;

        _time = time;

        //_distance = distance;

       


    }



public void SetTime(int time)
    {
        
        _time = time;


    }

public int GetTime()
    {
        

        return _time;
    }


public virtual double GetDistance()
    {
        
        return 1.0 ;
    }


public virtual double GetSpeed()
    {
        
        return 1.0;


    }


public virtual double GetPace()
    {
        
        return _time;



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
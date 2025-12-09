public class Activity
{
    
private DateOnly _date;

private int _time;


private double _distance;


private string _type;


private double _speed;

private double _pace;


public Activity(DateOnly date, string type, int time, double distance, double speed, double pace)
    {
        
        _date = date;

        _type = type;

        _time = time;

        _distance = distance;

        _speed = speed;

        _pace = pace;


    }

  public virtual string GetSummary()
    {
        
        return $"{_date} {_type} ({_time} min)- Distance{_distance} km, Speed:{_speed} kph, Pace:{_pace} min per km";

    }







}
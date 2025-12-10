public class Cycling : Activity
{
    


public Cycling (DateOnly date, string type, int time, double distance) : base(date, type, time, distance)
    {
        

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
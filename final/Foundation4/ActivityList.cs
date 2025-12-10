public class ActivityList
{
    

private List<Activity> _activites = new List<Activity>();



public void AddActivity(Activity activity)
    {
        
        _activites.Add(activity);


    }


public void DisplayAll()
    {
        
        Console.WriteLine("--Workout Log--");


        foreach (Activity activity in _activites)
        {
            
            Console.WriteLine($"{activity.GetSummary()}");



        }

    }






}
public class ChecklistGoal : SimpleGoal
{
    
private int _timesCompleted;
private int _bonusPoints;
private int _goalofCompletions;



public  ChecklistGoal (string name, string description, int points, int goalOfCompletions, int bonusPoints) 

: base(name, description, points)

    {
        
        _bonusPoints = points;
        _goalofCompletions = goalOfCompletions;
        _bonusPoints = bonusPoints;
        _timesCompleted = 0;

    }

public override void Display()
    {
        



    }



public override string ToString()
    { 
        return $"Check List Goal: {_name}, {_description}, {_points},{_bonusPoints},{_goalofCompletions},{_timesCompleted}";
    }




}
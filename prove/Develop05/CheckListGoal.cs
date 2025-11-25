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
        return $"Check List Goal: {_name}, {_description}, {_points},{_bonusPoints},{_goalofCompletions},{_timesCompleted},{_done}";
    }

    public override string GetGoalType()
    {
        return "Check List Goal:";
    }

    public int GetTimesCompleted()
    {
        
        return _timesCompleted;
    }

    public int GetGoalOfCompletions()
    {
        
        return _goalofCompletions;
    }

    public override int CompleteGoal()
    {
        _timesCompleted ++;

        if (_timesCompleted >= _goalofCompletions && !_done)
        {
            
            _done = true;

            return _points + _bonusPoints;
        }

        return _points;

    }


}
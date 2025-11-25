public class EternalGoal : SimpleGoal
{
    


public EternalGoal(string name, string description, int points) 

: base(name, description, points){ }



 public override void Display()
    {
      
    }

 public override string ToString()
    {
        return $"Eternal Goal: {_name}, {_description}, {_points},{_done}";
    }

    public override string GetGoalType()
    {
        return "Eternal Goal:";
    }

   



}
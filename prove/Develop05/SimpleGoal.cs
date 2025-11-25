public class SimpleGoal
{
    //Attributes//



    protected string _name;

    protected string _description;


    protected int _points;


    protected bool _done;




    // Constructors//

    // This gets the / stores the users input for the name of their goal and description of that goal.
    public SimpleGoal(string name, string description, int points)
    {
        
        _name = name;

        _description = description;

        _points = points;

        _done = false;


    }

    public void SetDone()
    {
        
        _done = true;


    }



    // points for each completed activity
    public void Points(int points)
    {
        
        _points = points;

    }



    public virtual int CompleteGoal()
    {
        
      
        SetDone();

        return _points;




    }

    public void DisplayName()
    {
        
        Console.WriteLine($"{_name}");

    }

    public virtual void Display ()
    {
       Console.WriteLine($"Goal: {_name}");
       Console.WriteLine($"Goal Description: {_description}");
       Console.WriteLine($"Points for {_name}: {_points}");
       


    }


    public override string ToString()
    {
        return $"Simple Goal: {_name}, {_description}, {_points},{_done}";
    }

    public string GetName()
    {
        
        return _name;
    }

    public string GetDescription()
    {
        
        return _description;

    }

    public virtual string GetGoalType()
    {
        

        return "Simple Goal:";
    }











}
public abstract class SimpleGoal
{
    //Attributes//



    private string _name;

    private string _description;


    private int _points;


    private bool _done;




    // Constructors//

    // This gets the / stores the users input for the name of their goal and description of that goal.
    public SimpleGoal(string name, string description, int points)
    {
        
        _name = name;

        _description = description;

        _points = points;

        _done = false;


    }



    // points for each completed activity
    public void Points(int points)
    {
        
        _points = points;

    }



    public void CompleteGoal()
    {
        
      





    }

    public virtual void Display ()
    {
       Console.WriteLine($"Goal: {_name}");
       Console.WriteLine($"Goal Description: {_description}");
       Console.WriteLine($"Points for {_name}: {_points}");
       


    }












}
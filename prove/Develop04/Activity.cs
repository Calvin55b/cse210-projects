public class Activity
{

    //Attributes//
    private string _title;


    private string _description;

    private int _duration;




    // Constructor//

    public Activity(string titleP, string descriptionP)
    {
        _title = titleP;


        _description = descriptionP;

        _duration = 0;


    }


    public int Duration
    {


        get { return _duration; }

        set{ _duration = value; }



    }


    // Shows the title, welcome message, and prompt for how long the session.
    public void RunBegin()
    {

        Console.WriteLine($"{_title} \n {_description} \n How long, in seconds, would you like for your session?");

        string userInput = Console.ReadLine();

        _duration = int.Parse(userInput);



    }
    

    // This says 'well done !!!' and states that you completed the activity and says which activity and how long the activity was.
    public void RunEnd()
    {

        Console.WriteLine($"Well done !!!");


        Console.WriteLine($"You have completed another {_duration} seconds of the {_title}");
        




    }







}
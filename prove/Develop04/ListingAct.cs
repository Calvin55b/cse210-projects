public class Listing : Activity
{

    private List<string> _Entries = new List<string>() { };
    private List<string> _Prompt = new List<string>()
    {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"
    };


    //This is basically a constructor for the class and adds the two strings that almost every class inherits from the parent class.
    public Listing() : base("Listing Activity", @"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    public void DisplayPrompt()
    {

        Console.WriteLine(@"List as many responses you can to the following prompt: ");

        int numI = _Prompt.Count;
        Random random = new Random();
        int randI = random.Next(0, numI);
        Console.WriteLine(_Prompt[randI]);

    }
    


    public void UserEntries()
    {
        Timer timer = new Timer();
        timer.TimerToBegin();
        DateTime startTime = DateTime.Now;
        int countDown = 10;
        while ((DateTime.Now - startTime).TotalSeconds < countDown)
        {

            Console.WriteLine("> ");

            string userInput = Console.ReadLine();

            _Entries.Add(userInput);

        }
        Console.WriteLine();

        Console.WriteLine($"You listed {_Entries.Count} items!");
        
        


    }

    



    




}
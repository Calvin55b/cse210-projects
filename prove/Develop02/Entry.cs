public class Entry
{
    //attribuites



    public string _dateTime;


    public string _prompt;

    public string _userEntry;



    // behavior

    public void Prompt()
    {
        List<string> listofPrompts = new List<string>();
        listofPrompts.Add("Who was the most interesting person I interacted with today?");
    
        listofPrompts.Add("What was the best part of my day?");
        
        listofPrompts.Add("How did I see the hand of the Lord in my life today?");

        listofPrompts.Add("If I had one thing I could do over today, what would it be?");

        listofPrompts.Add("What did you do for the plot today?");

        Random random = new Random();

        int randomPrompt = random.Next(listofPrompts.Count);

        Console.WriteLine(listofPrompts[randomPrompt]);

        _prompt = listofPrompts[randomPrompt];

        
    }

    public void Write()
    {
        Prompt();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _dateTime = dateText;
    
        Console.Write(">");
        _userEntry = Console.ReadLine();
        
    }

    public void DisplayEntry() {

        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"{_userEntry}");
        Console.WriteLine();
        

        
        
    }
}


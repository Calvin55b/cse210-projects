public class Reflection : Activity
{

    private List<string> _Prompts = new List<string>() { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };


    private List<string> _Questions = new List<string>()
    {
        "Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?"
    };


    public Reflection() : base("Reflecting Activity.",


    @"This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recongnize the power you have and how you can use it in other aspects of your life.")
    { }

    public void displayRandomPrompt()
    {
        Console.WriteLine("Consider the following prompt:");

        int numI = _Prompts.Count;
        Random random = new Random();
        int randI = random.Next(0, numI);
        Console.WriteLine(_Prompts[randI]);


        Console.WriteLine("When you have something in mind, press enter to continue.");

        Console.ReadLine();






    }
    

    public void displayQuestion()
    {
        Timer timer = new Timer();
            
        int numTime = Duration * 1000 / _Questions.Count;

        for (int i = 0; i < _Questions.Count; i++)
        {
            Console.Write(_Questions[i]);
            timer.PauseWithAnimation();
            Thread.Sleep(numTime);
            Console.WriteLine();
            
            




        }


        




    }



}